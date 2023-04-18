using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics.SymbolStore;

namespace StatCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.RowCount = CharactersData.AllCharacters.Length;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "      Персонаж";
            dataGridView1.Columns[1].HeaderText = "        Статы";
            dataGridView1.Columns[2].HeaderText = "          Сет";
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.Black; 
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            double atkroll = 0, defroll = 0, hproll = 0, erroll = 0, critdmgroll = 0, critrateroll = 0, emroll = 0, atk = 0, def = 0, hp = 0, er = 0, critdmg = 0, critrate = 0, em = 0, sum = 9, sum1 = 4; 
            bool mistake = false;

            if(comboBox_piece.Text == "Цветок")
            {
                comboBox_mainstat.Text = "HP, плоск.";
            }
            if (comboBox_piece.Text == "Перо")
            {
                comboBox_mainstat.Text = "Сила атаки, плоск.";
            }

            TextBox[] textboxes = new TextBox[] { textBox_atk, textBox_hp, textBox_def, textBox_critdmg, textBox_critrate, textBox_er, textBox_em };            
            double[] stats = new double[] { atk, hp, def, critdmg, critrate, er, em };     // Списочек введенных статов
            double[] maxst = new double[] { 34.8, 34.8, 43.8, 46.8, 23.4, 39, 138 }; // Макс. роллы в один из статов
            double[] rolls = new double[] { atkroll, hproll, defroll, critdmgroll, critrateroll, erroll, emroll }; // Список в котором хранится кол-во роллов
            double[] r2 = new double[] { 5, 5, 6.2, 6.6, 3.3, 5.5, 19 }; // Средний ролл в один из статов
            string[] list = new string[] { "Сила атаки %", "HP %", "Защита %", "Крит. урон %", "Шанс крит. попадания %", "Восст. энергии %", "Мастерство стихий" };
             



            for (int i = 0; i < 7; i++)
            {
                textboxes[i].Text = textboxes[i].Text.Replace(".", ","); // замена запятой на точку
                if (textboxes[i].Text == "")
                    textboxes[i].Text = "0";                            

                try
                {
                    stats[i] = Convert.ToDouble(textboxes[i].Text);       // перевод в количественную переменную вместо текстовой
                }

                catch (Exception)
                {                    
                    mistake = true;
                }

                if (comboBox_mainstat.Text == list[i] & stats[i] > 0) // ошибка при попытке ввести роллы в комбобокс в верхний стат
                {
                    mistake = true;
                }

                if (stats[i] > 0)
                {
                    sum1 -= 1;                                    
                    rolls[i] = Math.Round(stats[i] / r2[i], 0);  
                    sum -= rolls[i];                                               
                    if (stats[i] <= maxst[i] & rolls[i] >= 6)  // пробел между 9 средними роллами и 1 макс роллом в один стат и 3 роллами в статы 
                    {
                        sum = 1;
                    }
                    if (stats[i] > maxst[i])  // чекинг на превышение макс статов
                    {
                        sum1 = -1;
                    }                    
                }
            }


            if (mistake == true)
            {
                MessageBox.Show("Неверный формат ввода!"); // вывод ошибки при неверном формате боксов
            }
            else if (sum1 < 0) 
            {
                MessageBox.Show("Слишком много роллов!"); // более 4 статов заполнено              
            }
            else if (sum < 0)
            {
                MessageBox.Show("Слишком много роллов!"); // более 9 роллов                
            }        
            else
            {

                Artefact a = new Artefact(Convert.ToDouble(textBox_atk.Text), Convert.ToDouble(textBox_hp.Text),
                                          Convert.ToDouble(textBox_def.Text), Convert.ToDouble(textBox_er.Text),
                                          Convert.ToDouble(textBox_em.Text), Convert.ToDouble(textBox_critdmg.Text),
                                          Convert.ToDouble(textBox_critrate.Text), comboBox_set.Text, comboBox_mainstat.Text, comboBox_piece.Text);

                int i = 0;
                foreach (Character character in CharactersData.AllCharacters)
                {
                    WriteInTable(character, a, character.Name, i);
                    i++;
                }
            }
        }

        //Микрофункция возвращающая результат чекинга арта на предмет его профпригодности для конкретного перса
        public string Stat_Function(Character character, Artefact a)
        {
            return character.Check(a);
        }
        //Функция возвращающая инфу о релевантности артсета
        public string Set_Function(Character character, Artefact a)
        {
            bool error = true;

            if (comboBox_set.Text == "")
                return "Введи сет";

            if (a.Piece == "Часы")
                foreach (string stat in character.ClockStats)
                    if (stat == a.MainStat)
                        error = false;
            if (a.Piece == "Кубок")
                foreach (string stat in character.GobletStats)
                    if (stat == a.MainStat)
                        error = false;
            if (a.Piece == "Шапка")
                foreach (string stat in character.CrownStats)
                    if (stat == a.MainStat)
                        error = false;
            if (a.Piece == "Цветок" || a.Piece == "Перо")
                error = false;

            if (error == true)
                return "-";

            foreach (string set in character.MainSets)
            {
                if (set == comboBox_set.Text)
                {
                    return "Сетник";
                }
            }
            foreach (string set in character.AltSets)
            {
                if (set == comboBox_set.Text)
                {
                    return "Альтернатива";
                }
            }

            foreach (string set in character.SubSets)
            {
                if (set == comboBox_set.Text)
                {
                    return "Солянка";
                }
            }

            return "Оффсетник";
        }

        //Метод для покраски стата
        public Color ColorizeStat(string s)
        {
            if (s == "Идеально")
                return Color.GreenYellow;
            else if (s == "Отлично")
                return Color.Yellow;
            else if (s == "Хорошо")
                return Color.Orange;
            else if (s == "-")
                return Color.White;
            else
                return Color.Black;
        }

        //Метод для покраски сета
        public Color ColorizeSet(string s)
        {
            if (s == "Сетник")
                return Color.GreenYellow;
            else if (s == "Альтернатива")
                return Color.LightBlue;
            else if (s == "Солянка")
                return Color.Orange;
            else if (s == "Оффсетник")
                return Color.DeepPink;
            else if (s == "-")
                return Color.White;
            else
                return Color.Black;
        }

        public void WriteInTable(Character c, Artefact a, string name, int i)
        {
            string stat = Stat_Function(c, a);
            string set = Set_Function(c, a);
            Color aa = ColorizeStat(stat);
            Color bb = ColorizeSet(set);           
            dataGridView1.Rows[i].Cells[0].Value = name;
            dataGridView1.Rows[i].Cells[1].Value = stat;
            dataGridView1.Rows[i].Cells[1].Style.ForeColor = aa;
            dataGridView1.Rows[i].Cells[2].Value = set;
            dataGridView1.Rows[i].Cells[2].Style.ForeColor = bb;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_atk.Text = "";
            textBox_fnd.Text = "";
            textBox_hp.Text = "";
            textBox_def.Text = "";
            textBox_critdmg.Text = "";
            textBox_critrate.Text = "";
            textBox_er.Text = "";
            textBox_em.Text = "";
            comboBox_set.Text = "";
            comboBox_piece.Text = "";
            comboBox_mainstat.Text = "";
        }

        private void pictureBox_fnd_Click(object sender, EventArgs e)
        {
            int k = 0; //счётчик совпадений
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox_fnd.Text.ToLower()))
                        {
                            dataGridView1.Rows[k].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                            dataGridView1.Rows[k].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                            dataGridView1.Rows[k].Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value;
                            k++;
                            break;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[0].Value = ' ';
                            dataGridView1.Rows[i].Cells[1].Value = ' ';
                            dataGridView1.Rows[i].Cells[2].Value = ' ';
                        }   
            }
            k = 0;
        }
    } 
}
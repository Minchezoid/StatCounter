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

namespace StatCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.RowCount = CharactersData.AllCharacters.Length;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "Персонаж";
            dataGridView1.Columns[1].HeaderText = "Статы";
            dataGridView1.Columns[2].HeaderText = "Сет";
            dataGridView1.Columns[0].Width = 120; 
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            for (int i = 0; i < ArtNamesData.AllArtefacts.Length; i++)
            {
                comboBox_set.Items.Add(ArtNamesData.AllArtefacts[i]);
            }
            comboBox_mainstat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_set.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_piece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        //Создание второй таблицы (для бэкапа после функции поиска)
        public static DataGridView dataGridView2 = new DataGridView();

        public void button1_Click(object sender, EventArgs e)
        {
            double atk = 0;
            double hp = 0;
            double def = 0;
            double critdmg = 0;
            double critrate = 0;
            double er = 0;
            double em = 0;
            bool mistake = false;

            TextBox[] textboxes = new TextBox[] { textBox_atk, textBox_hp, textBox_def, textBox_critdmg, textBox_critrate, textBox_er, textBox_em };
            double[] stats = new double[] { atk, hp, def, critdmg, critrate, er, em };
            string[] statNames = new string[] { StatNamesData.ATK_PERCENT, StatNamesData.HP_PERCENT, StatNamesData.DEF_PERCENT, StatNamesData.CRIT_DMG, StatNamesData.CRIT_RATE, StatNamesData.ENERGY_RECHARGE, StatNamesData.ELEMENTAL_MASTERY };
            double[] maximumRolls = new double[] { MaximumRoll.ATK_PERCENT, MaximumRoll.HP_PERCENT, MaximumRoll.DEF_PERCENT, MaximumRoll.CRIT_DMG, MaximumRoll.CRIT_RATE, MaximumRoll.ENERGY_RECHARGE, MaximumRoll.ELEMENTAL_MASTERY };

            for (int i = 0; i < stats.Length; i++)
            {
                if (textboxes[i].Text == "")
                    stats[i] = 0;
                else
                    stats[i] = Convert.ToDouble(textboxes[i].Text);
            }

            int maxRollsCount = 9;
            int maxDifferentStats = 4;
            int maxLvlRolls = 5; //кол-во роллов при прокачке

            for (int i = 0; i < statNames.Length; i++)
            {
                if (comboBox_mainstat.Text == statNames[i] & stats[i] > 0)
                {
                    MessageBox.Show("Верхний и нижний стат повторяться не могут!");
                    mistake = true;
                }

                if (stats[i] > 0)
                {
                    maxDifferentStats -= 1;  // минусуем одну ячейку в которой есть данные чтобы не было более 4 статов
                    maxRollsCount -= Convert.ToInt32(Math.Ceiling(stats[i] / maximumRolls[i])); // минусуем кол-во роллов от общего числа
                    maxLvlRolls -= (Convert.ToInt32(Math.Ceiling(stats[i] / maximumRolls[i])) - 1); // если роллов в один стат больше одного, тогда отнимаем число доп. роллов
                }

                if (mistake == false)
                {
                    if ((maxRollsCount < 0) || (maxDifferentStats < 0) || (maxLvlRolls < 0)) // четырехстатник
                    {
                        MessageBox.Show("Вы ввели слишком много статов!");
                        mistake = true;
                    }
                }

            }

            if (mistake == false)
            {
                Artefact a = new Artefact(stats[0], stats[1], stats[2],
                                          stats[5], stats[6], stats[3],
                                          stats[4], comboBox_set.Text, comboBox_mainstat.Text, comboBox_piece.Text);

                int i = 0;
                foreach (Character character in CharactersData.AllCharacters)
                {
                    WriteInTable(character, a, character.Name, i);
                    i++;
                }

                dataGridView2.RowCount = CharactersData.AllCharacters.Length;
                dataGridView2.ColumnCount = 3;
                for (int j = 0; j < dataGridView1.RowCount; j++)
                    for (int k = 0; k < dataGridView1.ColumnCount; k++)
                        dataGridView2.Rows[j].Cells[k].Value = dataGridView1.Rows[j].Cells[k].Value;

            }

        }

        //Микрофункция возвращающая результат чекинга арта на предмет его профпригодности для конкретного перса
        public string Stat_Function(Character character, Artefact artefact)
        {
            return Check(artefact, character);
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
            else if (s == "СОВЕРШЕННО!")
                return Color.LightSkyBlue;
            else if (s == "Так себе")
                return Color.Red;
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
            Color statColor = ColorizeStat(stat);
            Color setColor = ColorizeSet(set);
            dataGridView1.Rows[i].Cells[0].Value = name;
            dataGridView1.Rows[i].Cells[1].Value = stat;
            dataGridView1.Rows[i].Cells[1].Style.ForeColor = statColor;
            dataGridView1.Rows[i].Cells[2].Value = set;
            dataGridView1.Rows[i].Cells[2].Style.ForeColor = setColor;
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

        public void Search(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView2.RowCount; j++)
                for (int m = 0; m < dataGridView2.ColumnCount; m++)
                    dataGridView1.Rows[j].Cells[m].Value = dataGridView2.Rows[j].Cells[m].Value;

            int k = 0; //счётчик совпадений
            string s1;
            string s2;
            string s3;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox_fnd.Text.ToLower()))
                        {
                            s1 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            s2 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            s3 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            dataGridView1.Rows[i].Cells[0].Value = ' ';
                            dataGridView1.Rows[i].Cells[1].Value = ' ';
                            dataGridView1.Rows[i].Cells[2].Value = ' ';
                            dataGridView1.Rows[k].Cells[0].Value = s1;
                            dataGridView1.Rows[k].Cells[1].Value = s2;
                            dataGridView1.Rows[k].Cells[2].Value = s3;
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

            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                Color statColor = ColorizeStat(dataGridView1.Rows[j].Cells[1].Value.ToString());
                Color setColor = ColorizeSet(dataGridView1.Rows[j].Cells[2].Value.ToString());
                dataGridView1.Rows[j].Cells[1].Style.ForeColor = statColor;
                dataGridView1.Rows[j].Cells[2].Style.ForeColor = setColor;
            }

        }

        private void pictureBox_fnd_Click(object sender, EventArgs e)
        {
            Search(sender, e);
        }

        public void KeyControl(KeyPressEventArgs e, TextBox textbox, double max)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                    return;
            }

            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if ((textbox.Text.IndexOf(',') != -1) && (textbox.Text[textbox.Text.Length-1] != ',')) //нельзя ввести больше 1 знака после запятой
                    e.Handled = true;
                if ((textbox.Text == "") && (e.KeyChar == '0')) // нельзя первым символом набрать 0
                    e.Handled = true;
                if (textbox.Text.IndexOf(',') == -1)
                {
                    if (Convert.ToDouble(textbox.Text + e.KeyChar) > max)
                        if (textbox == textBox_em)
                            e.Handled = true;
                        else
                        {
                            textbox.Text += ',';
                            textbox.Text += e.KeyChar;
                            e.Handled = true;
                        }
                }
                // цифра
                return;
            }

            if (textbox == textBox_em)
                e.Handled = true;

            if ((e.KeyChar == '.') || (e.KeyChar == 'б') || (e.KeyChar == 'ю') || (e.KeyChar == '/'))
            {
                // точку, а также "б", "ю" и "/" заменим запятой (раскладка moment)
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',') //запрещаем запятую в качестве первого знака
            {
                if (textbox.Text == String.Empty)
                    e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                if (textbox.Text.IndexOf(',') != -1)
                {
                    // запятая уже есть в поле редактирования
                    e.Handled = true;
                }
                return;
            }

            // остальные символы запрещены
            e.Handled = true;
        }

        

        public string Check(Artefact a, Character c)
        {
            c.First = 0;
            c.Second = 0;
            c.Third = 0;

            bool mainstatus = false;

            foreach (string stat in c.PerfectStats)
                if (a.MainStat == stat)
                {
                    mainstatus = true;
                    break;
                }
                else
                    continue;

            bool status = false;

            if (a.Piece == "Часы")
            {
                foreach (string stat in c.ClockStats)
                {
                    if (stat == a.MainStat)
                    {
                        status = true;
                        break;
                    }
                }

                if (status == false)
                    return "-";
            }
            else if (a.Piece == "Кубок")
            {
                foreach (string stat in c.GobletStats)
                {
                    if (stat == a.MainStat)
                    {
                        status = true;
                        break;
                    }
                }

                if (status == false)
                    return "-";
            }
            else if (a.Piece == "Шапка")
            {
                foreach (string stat in c.CrownStats)
                {
                    if (stat == a.MainStat)
                    {
                        status = true;
                        break;
                    }
                }

                if (status == false)
                    return "-";
            }

            foreach (string stat in c.PerfectStats)
            {
                if (stat == StatNamesData.CRIT_DMG)
                    c.First += a.CritDmg;
                else if (stat == StatNamesData.CRIT_RATE)
                    c.First += a.CritRate;
                else if (stat == StatNamesData.ATK_PERCENT)
                    c.First += a.Atk;
                else if (stat == StatNamesData.HP_PERCENT)
                    c.First += a.Hp;
                else if (stat == StatNamesData.DEF_PERCENT)
                    c.First += a.Def;
                else if (stat == StatNamesData.ENERGY_RECHARGE)
                    c.First += a.Er;
                else if (stat == StatNamesData.ELEMENTAL_MASTERY)
                    c.First += a.Em;
            }

            foreach (string stat in c.GoodStats)
            {
                if (stat == StatNamesData.CRIT_DMG)
                    c.Second += a.CritDmg;
                else if (stat == StatNamesData.CRIT_RATE)
                    c.Second += a.CritRate;
                else if (stat == StatNamesData.ATK_PERCENT)
                    c.Second += a.Atk;
                else if (stat == StatNamesData.HP_PERCENT)
                    c.Second += a.Hp;
                else if (stat == StatNamesData.DEF_PERCENT)
                    c.Second += a.Def;
                else if (stat == StatNamesData.ENERGY_RECHARGE)
                    c.Second += a.Er;
                else if (stat == StatNamesData.ELEMENTAL_MASTERY)
                    c.Second += a.Em;
            }

            foreach (string stat in c.OkStats)
            {
                if (stat == StatNamesData.CRIT_DMG)
                    c.Third += a.CritDmg;
                else if (stat == StatNamesData.CRIT_RATE)
                    c.Third += a.CritRate;
                else if (stat == StatNamesData.ATK_PERCENT)
                    c.Third += a.Atk;
                else if (stat == StatNamesData.HP_PERCENT)
                    c.Third += a.Hp;
                else if (stat == StatNamesData.DEF_PERCENT)
                    c.Third += a.Def;
                else if (stat == StatNamesData.ENERGY_RECHARGE)
                    c.Third += a.Er;
                else if (stat == StatNamesData.ELEMENTAL_MASTERY)
                    c.Third += a.Em;
            }

            //Третий по полезности стат переливаем во второй, деля его на 2
            c.Second += (c.Third / 2);

            //Считаем главные статы и добавляем чуточку во второй если у нас заминОЧКА
            if (c.First - Math.Truncate(c.First) > 0.8)
                c.First = Math.Truncate(c.First) + 1;
            else if (c.First - Math.Truncate(c.First) > 0.4)
            {
                c.First = Math.Truncate(c.First);
                c.Second += 1;
            }
            else
            {
                c.Second += (c.First - Math.Truncate(c.First)) / 2;
                c.First = Math.Truncate(c.First);
            }

            //Округляем второй по полезности стат
            if (c.Second - Math.Truncate(c.Second) > 0.8)
                c.Second = Math.Truncate(c.Second) + 1;
            else
                c.Second = Math.Truncate(c.Second);

            //Выведем это говнище в виде оценки чтобы челам понятно было

            if (a.Piece == "Цветок" | a.Piece == "Перо") //Оценка 1
            {
                if (c.First < 3)
                        return "-";
                else if (c.First == 3)
                    if (c.Second >= 2)
                        return "Так себе";
                    else
                        return "-";   
                else if (c.First == 4)
                    if (c.Second >= 2)
                        return "Хорошо";
                    else
                        return "Так себе";
                else if (c.First == 5)
                    if (c.Second >= 2)
                        return "Отлично";
                    else
                        return "Хорошо";
                else if (c.First == 6)
                    if (c.Second >= 2)
                        return "Идеально";
                    else
                        return "Отлично";
                else if (c.First == 7)
                    if (c.Second >= 2)
                        return "СОВЕРШЕННО!";
                    else
                        return "Идеально";
                else
                    return "СОВЕРШЕННО!";
            }
            else if (a.Piece == "Часы")
            {
                if (mainstatus == true) //Оценка 2
                {
                    if (c.Second / 2 >= 1)
                    {
                        c.First += (c.Second / 2) - ((c.Second / 2) - Math.Truncate(c.Second / 2));
                        c.Second = c.Second - Math.Truncate(c.Second / 2) * 2;
                    }
                    if (c.First < 3)
                        return "-";
                    else if (c.First == 3)
                        if (c.Second >= 1)
                            return "Так себе";
                        else
                            return "-";
                    else if (c.First == 4)
                        if (c.Second >= 1)
                            return "Хорошо";
                        else
                            return "Так себе";
                    else if (c.First == 5)
                        if (c.Second >= 1)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (c.First == 6)
                        if (c.Second >= 1)
                            return "Идеально";
                        else
                            return "Отлично";
                    else if (c.First == 7)
                        if (c.Second >= 1)
                            return "СОВЕРШЕННО!";
                        else
                            return "Идеально";
                    else
                        return "СОВЕРШЕННО!";
                }
                else //Оценка 2 (+)
                {
                    if (c.First < 2)
                        return "-";
                    else if (c.First == 2)
                        if (c.Second >= 3)
                            return "Так себе";
                        else
                            return "-";
                    else if (c.First == 3)
                        if (c.Second >= 3)
                            return "Хорошо";
                        else if (c.Second >= 1)
                            return "Так себе";
                        else
                            return "-";
                    else if (c.First == 4)
                        if (c.Second >= 3)
                            return "Отлично";
                        else if (c.Second >= 1)
                            return "Хорошо";
                        else
                            return "Так себе";
                    else if (c.First == 5)
                        if (c.Second >= 3)
                            return "Идеально";
                        else if (c.Second >= 1)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (c.First == 6)
                        if (c.Second >= 3)
                            return "СОВЕРШЕННО!";
                        else if (c.Second >= 1)
                            return "Идеально";
                        else
                            return "Отлично";
                    else if (c.First == 7)
                        if (c.Second >= 1)
                            return "СОВЕРШЕННО!";
                        else
                            return "Идеально";
                    else
                        return "СОВЕРШЕННО!";
                }
            }
            else if (a.Piece == "Кубок")
            {
                if (mainstatus == true) //Оценка 3
                {
                    if (c.Second / 2 >= 1)
                    {
                        c.First += (c.Second / 2) - ((c.Second / 2) - Math.Truncate(c.Second / 2));
                        c.Second = c.Second - Math.Truncate(c.Second / 2) * 2;
                    }
                    if (c.First < 3)
                        return "-";
                    else if (c.First == 3)
                        return "Так себе";
                    else if (c.First == 4)
                        return "Хорошо";
                    else if (c.First == 5)
                        return "Отлично";
                    else if (c.First == 6)
                        return "Идеально";
                    else if (c.First == 7)
                        return "СОВЕРШЕННО!";
                    else
                        return "СОВЕРШЕННО!";
                }
                else //Оценка 3 (+)
                {
                    if (c.First < 2)
                        return "-";
                    else if (c.First == 2)
                        if (c.Second >= 2)
                            return "Так себе";
                        else
                            return "-";
                    else if (c.First == 3)
                        if (c.Second >= 2)
                            return "Хорошо";
                        else
                            return "Так себе";
                    else if (c.First == 4)
                        if (c.Second >= 2)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (c.First == 5)
                        if (c.Second >= 2)
                            return "Идеально";
                        else
                            return "Отлично";
                    else if (c.First == 6)
                        if (c.Second >= 2)
                            return "СОВЕРШЕННО!";
                        else
                            return "Идеально";
                    else
                        return "СОВЕРШЕННО!";
                }

            }
            else if (a.Piece == "Шапка")
            {
                if (mainstatus == true) //Оценка 4
                {
                    if (c.Second / 2 >= 1)
                    {
                        c.First += (c.Second / 2) - ((c.Second / 2) - Math.Truncate(c.Second / 2));
                        c.Second = c.Second - Math.Truncate(c.Second / 2) * 2;
                    }
                    if (c.First < 2)
                        return "-";
                    else if (c.First == 2)
                        if (c.Second >= 1)
                            return "Так себе";
                        else
                            return "-";
                    else if (c.First == 3)
                        if (c.Second >= 1)
                            return "Хорошо";
                        else
                            return "Так себе";
                    else if (c.First == 4)
                        if (c.Second >= 1)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (c.First == 5)
                        if (c.Second >= 1)
                            return "Идеально";
                        else
                            return "Отлично";
                    else if (c.First == 6)
                        if (c.Second >= 1)
                            return "СОВЕРШЕННО!";
                        else
                            return "Идеально";
                    else
                        return "СОВЕРШЕННО!";
                }
                else //Оценка 4 (+)
                {
                    if (c.First < 1)
                        return "-";
                    else if (c.First == 1)
                        if (c.Second >= 3)
                            return "Так себе";
                        else
                            return "-";
                    else if (c.First == 2)
                        if (c.Second >= 3)
                            return "Хорошо";
                        else if (c.Second >= 1)
                            return "Так себе";
                        else
                            return "-";
                    else if (c.First == 3)
                        if (c.Second >= 3)
                            return "Отлично";
                        else if (c.Second >= 1)
                            return "Хорошо";
                        else
                            return "Так себе";
                    else if (c.First == 4)
                        if (c.Second >= 3)
                            return "Идеально";
                        else if (c.Second >= 1)
                            return "Отлично";
                        else
                            return "Хорошо";
                    else if (c.First == 5)
                        if (c.Second >= 3)
                            return "СОВЕРШЕННО!";
                        else if (c.Second >= 1)
                            return "Идеально";
                        else
                            return "Отлично";
                    else if (c.First == 6)
                        if (c.Second >= 1)
                            return "СОВЕРШЕННО!";
                        else
                            return "Идеально";
                    else
                        return "СОВЕРШЕННО!";
                }
            }
            else
                return "Выбери кусок!";
        }

        private void textBox_atk_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl(e, textBox_atk, StatBounds.ATK_MAXIMUM);
        }

        private void textBox_hp_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl(e, textBox_hp, StatBounds.HP_MAXIMUM);
        }

        private void textBox_def_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl(e, textBox_def, StatBounds.DEF_MAXIMUM);
        }

        private void textBox_er_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl(e, textBox_er, StatBounds.ER_MAXIMUM);
        }

        private void textBox_em_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl(e, textBox_em, StatBounds.EM_MAXIMUM);
        }

        private void textBox_critdmg_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl(e, textBox_critdmg, StatBounds.CRITDMG_MAXIMUM);
        }

        private void textBox_critrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl(e, textBox_critrate, StatBounds.CRITRATE_MAXIMUM);
        }

        private void comboBox_piece_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_piece.Text == "Цветок")
            {
                comboBox_mainstat.Items.Clear();
                comboBox_mainstat.Items.Add(StatNamesData.HP_FLAT);
                comboBox_mainstat.Text = StatNamesData.HP_FLAT;
            }
            if (comboBox_piece.Text == "Перо")
            {
                comboBox_mainstat.Items.Clear();
                comboBox_mainstat.Items.Add(StatNamesData.ATK_FLAT);
                comboBox_mainstat.Text = StatNamesData.ATK_FLAT;
            }
            if (comboBox_piece.Text == "Часы")
            {
                comboBox_mainstat.Items.Clear();
                foreach (string stat in StatNamesData.ClockStats)
                {
                    comboBox_mainstat.Items.Add(stat);
                }
            }
            if (comboBox_piece.Text == "Кубок")
            {
                comboBox_mainstat.Items.Clear();
                foreach (string stat in StatNamesData.GobletStats)
                {
                    comboBox_mainstat.Items.Add(stat);
                }
            }
            if (comboBox_piece.Text == "Шапка")
            {
                comboBox_mainstat.Items.Clear();
                foreach (string stat in StatNamesData.CrownStats)
                {
                    comboBox_mainstat.Items.Add(stat);
                }
            }
        }

        private void textBox_fnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    Search(sender, e);
            }
        }
    } 
}
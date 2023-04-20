namespace StatCounter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_atk = new System.Windows.Forms.TextBox();
            this.textBox_critrate = new System.Windows.Forms.TextBox();
            this.textBox_critdmg = new System.Windows.Forms.TextBox();
            this.textBox_em = new System.Windows.Forms.TextBox();
            this.textBox_er = new System.Windows.Forms.TextBox();
            this.textBox_def = new System.Windows.Forms.TextBox();
            this.textBox_hp = new System.Windows.Forms.TextBox();
            this.textBox_fnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_set = new System.Windows.Forms.ComboBox();
            this.comboBox_piece = new System.Windows.Forms.ComboBox();
            this.comboBox_mainstat = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox_fnd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fnd)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(225, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 66);
            this.button1.TabIndex = 11;
            this.button1.Text = "Чекнуть арт";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_atk
            // 
            this.textBox_atk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_atk.Location = new System.Drawing.Point(28, 64);
            this.textBox_atk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_atk.Name = "textBox_atk";
            this.textBox_atk.Size = new System.Drawing.Size(116, 23);
            this.textBox_atk.TabIndex = 1;
            this.textBox_atk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_atk_KeyPress);
            // 
            // textBox_critrate
            // 
            this.textBox_critrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_critrate.Location = new System.Drawing.Point(159, 198);
            this.textBox_critrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_critrate.Name = "textBox_critrate";
            this.textBox_critrate.Size = new System.Drawing.Size(116, 23);
            this.textBox_critrate.TabIndex = 7;
            this.textBox_critrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_critrate_KeyPress);
            // 
            // textBox_critdmg
            // 
            this.textBox_critdmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_critdmg.Location = new System.Drawing.Point(159, 144);
            this.textBox_critdmg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_critdmg.Name = "textBox_critdmg";
            this.textBox_critdmg.Size = new System.Drawing.Size(116, 23);
            this.textBox_critdmg.TabIndex = 6;
            this.textBox_critdmg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_critdmg_KeyPress);
            // 
            // textBox_em
            // 
            this.textBox_em.Location = new System.Drawing.Point(159, 90);
            this.textBox_em.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_em.Name = "textBox_em";
            this.textBox_em.Size = new System.Drawing.Size(116, 23);
            this.textBox_em.TabIndex = 5;
            this.textBox_em.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_em_KeyPress);
            // 
            // textBox_er
            // 
            this.textBox_er.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_er.Location = new System.Drawing.Point(159, 42);
            this.textBox_er.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_er.Name = "textBox_er";
            this.textBox_er.Size = new System.Drawing.Size(116, 23);
            this.textBox_er.TabIndex = 4;
            this.textBox_er.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_er_KeyPress);
            // 
            // textBox_def
            // 
            this.textBox_def.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_def.Location = new System.Drawing.Point(28, 164);
            this.textBox_def.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_def.Name = "textBox_def";
            this.textBox_def.Size = new System.Drawing.Size(116, 23);
            this.textBox_def.TabIndex = 3;
            this.textBox_def.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_def_KeyPress);
            // 
            // textBox_hp
            // 
            this.textBox_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_hp.Location = new System.Drawing.Point(28, 113);
            this.textBox_hp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_hp.Name = "textBox_hp";
            this.textBox_hp.Size = new System.Drawing.Size(116, 23);
            this.textBox_hp.TabIndex = 2;
            this.textBox_hp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hp_KeyPress);
            // 
            // textBox_fnd
            // 
            this.textBox_fnd.Location = new System.Drawing.Point(737, 42);
            this.textBox_fnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_fnd.Name = "textBox_fnd";
            this.textBox_fnd.Size = new System.Drawing.Size(135, 23);
            this.textBox_fnd.TabIndex = 12;
            this.textBox_fnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_fnd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сила атаки %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(156, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Шанс крит. попадания %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(156, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Крит. урон %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(156, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Мастерство стихий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(156, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Восст. энергии %";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(23, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Защита %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "HP %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Сет";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Кусок";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Верхний стат";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(734, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Поиск";
            // 
            // comboBox_set
            // 
            this.comboBox_set.FormattingEnabled = true;
            this.comboBox_set.Location = new System.Drawing.Point(381, 168);
            this.comboBox_set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_set.Name = "comboBox_set";
            this.comboBox_set.Size = new System.Drawing.Size(253, 24);
            this.comboBox_set.TabIndex = 10;
            // 
            // comboBox_piece
            // 
            this.comboBox_piece.FormattingEnabled = true;
            this.comboBox_piece.Items.AddRange(new object[] {
            "Цветок",
            "Перо",
            "Часы",
            "Кубок",
            "Шапка"});
            this.comboBox_piece.Location = new System.Drawing.Point(436, 56);
            this.comboBox_piece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_piece.Name = "comboBox_piece";
            this.comboBox_piece.Size = new System.Drawing.Size(124, 24);
            this.comboBox_piece.TabIndex = 8;
            this.comboBox_piece.TextChanged += new System.EventHandler(this.comboBox_piece_TextChanged);
            // 
            // comboBox_mainstat
            // 
            this.comboBox_mainstat.FormattingEnabled = true;
            this.comboBox_mainstat.Location = new System.Drawing.Point(381, 115);
            this.comboBox_mainstat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_mainstat.Name = "comboBox_mainstat";
            this.comboBox_mainstat.Size = new System.Drawing.Size(253, 24);
            this.comboBox_mainstat.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(737, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(400, 341);
            this.dataGridView1.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 405);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox_fnd
            // 
            this.pictureBox_fnd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_fnd.Image")));
            this.pictureBox_fnd.Location = new System.Drawing.Point(879, 32);
            this.pictureBox_fnd.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_fnd.Name = "pictureBox_fnd";
            this.pictureBox_fnd.Size = new System.Drawing.Size(41, 34);
            this.pictureBox_fnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_fnd.TabIndex = 28;
            this.pictureBox_fnd.TabStop = false;
            this.pictureBox_fnd.Click += new System.EventHandler(this.pictureBox_fnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 446);
            this.Controls.Add(this.pictureBox_fnd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_mainstat);
            this.Controls.Add(this.comboBox_piece);
            this.Controls.Add(this.comboBox_set);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_hp);
            this.Controls.Add(this.textBox_def);
            this.Controls.Add(this.textBox_er);
            this.Controls.Add(this.textBox_em);
            this.Controls.Add(this.textBox_critdmg);
            this.Controls.Add(this.textBox_critrate);
            this.Controls.Add(this.textBox_fnd);
            this.Controls.Add(this.textBox_atk);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор артов v1.1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_atk;
        private System.Windows.Forms.TextBox textBox_critrate;
        private System.Windows.Forms.TextBox textBox_critdmg;
        private System.Windows.Forms.TextBox textBox_em;
        private System.Windows.Forms.TextBox textBox_er;
        private System.Windows.Forms.TextBox textBox_def;
        private System.Windows.Forms.TextBox textBox_hp;
        private System.Windows.Forms.TextBox textBox_fnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_set;
        private System.Windows.Forms.ComboBox comboBox_piece;
        private System.Windows.Forms.ComboBox comboBox_mainstat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox_fnd;
    }
}


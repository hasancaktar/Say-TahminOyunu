namespace SayıTahminOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioTekrarsiz = new System.Windows.Forms.RadioButton();
            this.radioTekrarli = new System.Windows.Forms.RadioButton();
            this.labelU = new System.Windows.Forms.Label();
            this.textBoxUzunluk = new System.Windows.Forms.TextBox();
            this.BtnSayiUret = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelGeriSayim = new System.Windows.Forms.Label();
            this.BtnTahmin = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.labelU);
            this.groupBox1.Controls.Add(this.textBoxUzunluk);
            this.groupBox1.Controls.Add(this.BtnSayiUret);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayı Üret";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioTekrarsiz);
            this.panel1.Controls.Add(this.radioTekrarli);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(140, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 59);
            this.panel1.TabIndex = 2;
            // 
            // radioTekrarsiz
            // 
            this.radioTekrarsiz.AutoSize = true;
            this.radioTekrarsiz.Location = new System.Drawing.Point(3, 30);
            this.radioTekrarsiz.Name = "radioTekrarsiz";
            this.radioTekrarsiz.Size = new System.Drawing.Size(269, 28);
            this.radioTekrarsiz.TabIndex = 0;
            this.radioTekrarsiz.TabStop = true;
            this.radioTekrarsiz.Text = "Rakamlar Tekrarlı Olamaz";
            this.radioTekrarsiz.UseVisualStyleBackColor = true;
            // 
            // radioTekrarli
            // 
            this.radioTekrarli.AutoSize = true;
            this.radioTekrarli.Location = new System.Drawing.Point(3, 3);
            this.radioTekrarli.Name = "radioTekrarli";
            this.radioTekrarli.Size = new System.Drawing.Size(265, 28);
            this.radioTekrarli.TabIndex = 0;
            this.radioTekrarli.TabStop = true;
            this.radioTekrarli.Text = "Rakamlar Tekrarlı Olabilir";
            this.radioTekrarli.UseVisualStyleBackColor = true;
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelU.Location = new System.Drawing.Point(2, 27);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(132, 24);
            this.labelU.TabIndex = 2;
            this.labelU.Text = "Uzunluğu Gir";
            // 
            // textBoxUzunluk
            // 
            this.textBoxUzunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUzunluk.Location = new System.Drawing.Point(6, 60);
            this.textBoxUzunluk.Name = "textBoxUzunluk";
            this.textBoxUzunluk.Size = new System.Drawing.Size(128, 28);
            this.textBoxUzunluk.TabIndex = 1;
            this.textBoxUzunluk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUzunluk_KeyPress);
            // 
            // BtnSayiUret
            // 
            this.BtnSayiUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSayiUret.Location = new System.Drawing.Point(6, 99);
            this.BtnSayiUret.Name = "BtnSayiUret";
            this.BtnSayiUret.Size = new System.Drawing.Size(435, 60);
            this.BtnSayiUret.TabIndex = 0;
            this.BtnSayiUret.Text = "Sayı Üret";
            this.BtnSayiUret.UseVisualStyleBackColor = true;
            this.BtnSayiUret.Click += new System.EventHandler(this.BtnSayiUret_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 8);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "     ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 8);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "0";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(48, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "     ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 8);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "0";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(93, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "     ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 8);
            this.textBox4.MaxLength = 1;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "0";
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(138, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "     ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(186, 7);
            this.textBox5.MaxLength = 1;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(39, 22);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "0";
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(185, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "     ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(231, 8);
            this.textBox6.MaxLength = 1;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(39, 22);
            this.textBox6.TabIndex = 2;
            this.textBox6.Text = "0";
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(232, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "     ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(276, 8);
            this.textBox7.MaxLength = 1;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(39, 22);
            this.textBox7.TabIndex = 2;
            this.textBox7.Text = "0";
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(276, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "     ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(321, 8);
            this.textBox8.MaxLength = 1;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(39, 22);
            this.textBox8.TabIndex = 2;
            this.textBox8.Text = "0";
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(323, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "     ";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(370, 8);
            this.textBox9.MaxLength = 1;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(41, 22);
            this.textBox9.TabIndex = 2;
            this.textBox9.Text = "0";
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(370, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "     ";
            // 
            // labelGeriSayim
            // 
            this.labelGeriSayim.AutoSize = true;
            this.labelGeriSayim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGeriSayim.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelGeriSayim.Location = new System.Drawing.Point(544, 236);
            this.labelGeriSayim.Name = "labelGeriSayim";
            this.labelGeriSayim.Size = new System.Drawing.Size(89, 46);
            this.labelGeriSayim.TabIndex = 5;
            this.labelGeriSayim.Text = "100";
            // 
            // BtnTahmin
            // 
            this.BtnTahmin.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTahmin.Location = new System.Drawing.Point(7, 85);
            this.BtnTahmin.Name = "BtnTahmin";
            this.BtnTahmin.Size = new System.Drawing.Size(400, 53);
            this.BtnTahmin.TabIndex = 6;
            this.BtnTahmin.Text = "TAHMİN ET";
            this.BtnTahmin.UseVisualStyleBackColor = true;
            this.BtnTahmin.Click += new System.EventHandler(this.BtnTahmin_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(742, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 132);
            this.listBox1.TabIndex = 7;
            this.listBox1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(726, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnTahmin);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 170);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(703, 50);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox10.Size = new System.Drawing.Size(233, 275);
            this.textBox10.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Fuchsia;
            this.label11.Location = new System.Drawing.Point(31, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "5 HAKKINIZ VAR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(327, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 46);
            this.label12.TabIndex = 12;
            this.label12.Text = "15";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(698, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 30);
            this.label13.TabIndex = 11;
            this.label13.Text = "SKOR TABLOSU";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSalmon;
            this.panel5.Location = new System.Drawing.Point(27, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(655, 31);
            this.panel5.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 30);
            this.label15.TabIndex = 11;
            this.label15.Text = "HAK SAYISI";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(480, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 30);
            this.label14.TabIndex = 11;
            this.label14.Text = "OYUN SÜRESİ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(263, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 30);
            this.label16.TabIndex = 11;
            this.label16.Text = "HAK SÜRESİ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Location = new System.Drawing.Point(486, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 168);
            this.panel2.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 336);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(501, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "NOT:  Tekrarsız sayı seçildiği zaman bilgisayarın hızına göre kasmalar olabilir.." +
    "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(970, 365);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.labelGeriSayim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioTekrarsiz;
        private System.Windows.Forms.RadioButton radioTekrarli;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.TextBox textBoxUzunluk;
        private System.Windows.Forms.Button BtnSayiUret;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelGeriSayim;
        private System.Windows.Forms.Button BtnTahmin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
    }
}


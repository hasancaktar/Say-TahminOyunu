using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SayıTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
            radioTekrarli.Checked = true;
            groupBox2.Visible = false;


        }

        int s1, s2, s3, s4, sayac = 100, sayac2=20;




        private void Form1_Load(object sender, EventArgs e)
        {
        }
        void kaydet()
        {
            FileStream fs = new FileStream("skor.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("SKOR:  " + sayac.ToString());
            sw.Close();
            fs.Close();

        }
        void oku()
        {
            FileStream fs2 = new FileStream("skor.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs2);
            textBox10.Text = sr.ReadToEnd();

            fs2.Close();
            sr.Close();
        }
        void tikla()
        {
            


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            sayac--;
            labelGeriSayim.Text = sayac.ToString();

            if (sayac == 0)
            {
                timer1.Stop();

                kaydet();
                MessageBox.Show("OYUN SÜRESİ BİTTİ " + label10.Text + " İDİ.. PANINIZ: 0");
                oku();


            }



        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxUzunluk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            sayac2--;
            label12.Text = sayac2.ToString();
            if(sayac2==0)
            {
                timer2.Stop();
                timer1.Stop();
                sayac = 0;
                kaydet();
                MessageBox.Show("SÜRENİZ BİTTİ. ÜRETİLEN SAYI "+label10.Text+" İDİ");
                oku();

            }
            
        }

        int tiklanma = 5;
        string besHak = "5 HAKKINIZ VAR";
        private void BtnTahmin_Click(object sender, EventArgs e)
        {
            sayac2 = 15;
            timer2.Start();
            if (textBoxUzunluk.Text == "1")
            {
                label11.Text = tiklanma + " HAKKINIZ KALDI";
                label1.BackColor = Color.Red;
                if (textBox1.Text == listBox1.Items[0].ToString())
                {
                    label1.BackColor = Color.Green;
                    timer1.Stop();
                    timer2.Stop();
                    kaydet();
                    MessageBox.Show("KAZANDINIZ PUANINIZ: "+labelGeriSayim.Text);
                    oku();
                    groupBox2.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;
                }
                // tikla();
                tiklanma--;
                label11.Text = tiklanma + " HAKKINIZ KALDI";
            }
            if (textBoxUzunluk.Text == "2")
            {
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox1.Text))
                        label1.BackColor = Color.Blue;
                    if (textBox1.Text == listBox1.Items[0].ToString())
                        label1.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox2.Text))
                        label2.BackColor = Color.Blue;
                    if (textBox2.Text == listBox1.Items[1].ToString())
                        label2.BackColor = Color.Green;
                }
                if (label1.BackColor == Color.Green &&
                label2.BackColor == Color.Green)
                {
                    timer1.Stop();
                    timer2.Stop();
                    kaydet();
                    MessageBox.Show("KAZANDINIZ PUANINIZ: " + labelGeriSayim.Text);
                    oku();
                    groupBox2.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;
                }

                if (tiklanma == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    sayac = 0;
                    kaydet();
                    MessageBox.Show("HAKKINIZ BİTTİ. TEKRAR DENEYİN.. ÜRETİLEN SAYI: "+label10.Text+" idi");
                    oku();
                    tiklanma = 5;
                    groupBox2.Visible = false;
                    label11.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;

                }
              //  tikla();
                tiklanma--;
                label11.Text = tiklanma + " HAKKINIZ KALDI";
            }
            if (textBoxUzunluk.Text == "3")
            {
                label11.Text = tiklanma + " HAKKINIZ KALDI";
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                label3.BackColor = Color.Red;
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox1.Text))
                        label1.BackColor = Color.Blue;
                    if (textBox1.Text == listBox1.Items[0].ToString())
                        label1.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox2.Text))
                        label2.BackColor = Color.Blue;
                    if (textBox2.Text == listBox1.Items[1].ToString())
                        label2.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox3.Text))
                        label3.BackColor = Color.Blue;
                    if (textBox3.Text == listBox1.Items[2].ToString())
                        label3.BackColor = Color.Green;
                }
                if (label1.BackColor == Color.Green &&
                label2.BackColor == Color.Green &&
                label3.BackColor == Color.Green)
                {
                    timer1.Stop();
                    timer2.Stop();
                    kaydet();
                    MessageBox.Show("KAZANDINIZ PUANINIZ: "+labelGeriSayim.Text);
                    oku();
                    groupBox2.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;

                }
                if (tiklanma == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    sayac = 0;
                    kaydet();
                    MessageBox.Show("HAKKINIZ BİTTİ. TEKRAR DENEYİN.. ÜRETİLEN SAYI: " + label10.Text + " idi");
                    oku();
                    tiklanma = 5;
                    groupBox2.Visible = false;
                    label11.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;

                }
                //tikla();
                tiklanma--;
                label11.Text = tiklanma + " HAKKINIZ KALDI";

            }
            if (textBoxUzunluk.Text == "4")
            {
                label11.Text = tiklanma + " HAKKINIZ KALDI";
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox1.Text))
                        label1.BackColor = Color.Blue;
                    if (textBox1.Text == listBox1.Items[0].ToString())
                        label1.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox2.Text))
                        label2.BackColor = Color.Blue;
                    if (textBox2.Text == listBox1.Items[1].ToString())
                        label2.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox3.Text))
                        label3.BackColor = Color.Blue;
                    if (textBox3.Text == listBox1.Items[2].ToString())
                        label3.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox4.Text))
                        label4.BackColor = Color.Blue;
                    if (textBox4.Text == listBox1.Items[3].ToString())
                        label4.BackColor = Color.Green;
                }
                if (label1.BackColor == Color.Green &&
                    label2.BackColor == Color.Green &&
                    label3.BackColor == Color.Green &&
                    label4.BackColor == Color.Green)
                {
                    timer1.Stop();
                    timer2.Stop();
                    kaydet();
                    MessageBox.Show("KAZANDINIZ PUANINIZ: " + labelGeriSayim.Text);
                    oku();
                    groupBox2.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;
                }


                if (tiklanma == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    sayac = 0;
                    kaydet();
                    MessageBox.Show("HAKKINIZ BİTTİ. TEKRAR DENEYİN.. ÜRETİLEN SAYI: " + label10.Text + " idi");
                    oku();
                    tiklanma = 5;
                    groupBox2.Visible = false;
                    label11.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;

                }
              //  tikla();
                tiklanma--;
                label11.Text = tiklanma + " HAKKINIZ KALDI";


            }
            if (textBoxUzunluk.Text == "5")
            {
                label11.Text = tiklanma + " HAKKINIZ KALDI";
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                label5.BackColor = Color.Red;

                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox1.Text))
                        label1.BackColor = Color.Blue;
                    if (textBox1.Text == listBox1.Items[0].ToString())
                        label1.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox2.Text))
                        label2.BackColor = Color.Blue;
                    if (textBox2.Text == listBox1.Items[1].ToString())
                        label2.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox3.Text))
                        label3.BackColor = Color.Blue;
                    if (textBox3.Text == listBox1.Items[2].ToString())
                        label3.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox4.Text))
                        label4.BackColor = Color.Blue;
                    if (textBox4.Text == listBox1.Items[3].ToString())
                        label4.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox5.Text))
                        label5.BackColor = Color.Blue;
                    if (textBox5.Text == listBox1.Items[4].ToString())
                        label5.BackColor = Color.Green;
                }
                if (label1.BackColor == Color.Green &&
                    label2.BackColor == Color.Green &&
                    label3.BackColor == Color.Green &&
                    label4.BackColor == Color.Green &&
                    label5.BackColor == Color.Green)
                {
                    timer1.Stop();
                    timer2.Stop();
                    kaydet();
                    MessageBox.Show("KAZANDINIZ PUANINIZ: " + labelGeriSayim.Text);
                    oku();
                    groupBox2.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;
                }

                if (tiklanma == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    sayac = 0;
                    kaydet();
                    MessageBox.Show("HAKKINIZ BİTTİ. TEKRAR DENEYİN.. ÜRETİLEN SAYI: " + label10.Text + " idi");
                    oku();
                    tiklanma = 5;
                    groupBox2.Visible = false;
                    label11.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;

                }


               // tikla();
                tiklanma--;
                label11.Text = tiklanma + " HAKKINIZ KALDI";

            }
            if (textBoxUzunluk.Text == "6")
            {
                label11.Text = tiklanma + " HAKKINIZ KALDI";
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                label5.BackColor = Color.Red;
                label6.BackColor = Color.Red;

                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox1.Text))
                        label1.BackColor = Color.Blue;
                    if (textBox1.Text == listBox1.Items[0].ToString())
                        label1.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox2.Text))
                        label2.BackColor = Color.Blue;
                    if (textBox2.Text == listBox1.Items[1].ToString())
                        label2.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox3.Text))
                        label3.BackColor = Color.Blue;
                    if (textBox3.Text == listBox1.Items[2].ToString())
                        label3.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox4.Text))
                        label4.BackColor = Color.Blue;
                    if (textBox4.Text == listBox1.Items[3].ToString())
                        label4.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox5.Text))
                        label5.BackColor = Color.Blue;
                    if (textBox5.Text == listBox1.Items[4].ToString())
                        label5.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox6.Text))
                        label6.BackColor = Color.Blue;
                    if (textBox6.Text == listBox1.Items[5].ToString())
                        label6.BackColor = Color.Green;
                }
                if (label1.BackColor == Color.Green &&
                    label2.BackColor == Color.Green &&
                    label3.BackColor == Color.Green &&
                    label4.BackColor == Color.Green &&
                    label5.BackColor == Color.Green &&
                    label6.BackColor == Color.Green)
                {
                    timer1.Stop();
                    timer2.Stop();
                    kaydet();
                    MessageBox.Show("KAZANDINIZ PUANINIZ: " + labelGeriSayim.Text);
                    oku();
                    groupBox2.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;

                }
                if (tiklanma == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    sayac = 0;
                    kaydet();
                    MessageBox.Show("HAKKINIZ BİTTİ. TEKRAR DENEYİN.. ÜRETİLEN SAYI: " + label10.Text + " idi");
                    oku();
                    tiklanma = 5;
                    groupBox2.Visible = false;
                    label11.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;

                }
                //tikla();
                tiklanma--;
                label11.Text = tiklanma + " HAKKINIZ KALDI";
            }
            if (textBoxUzunluk.Text == "7")
            {
                label11.Text = tiklanma + " HAKKINIZ KALDI";
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                label5.BackColor = Color.Red;
                label6.BackColor = Color.Red;
                label7.BackColor = Color.Red;


                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox1.Text))
                        label1.BackColor = Color.Blue;
                    if (textBox1.Text == listBox1.Items[0].ToString())
                        label1.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox2.Text))
                        label2.BackColor = Color.Blue;
                    if (textBox2.Text == listBox1.Items[1].ToString())
                        label2.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox3.Text))
                        label3.BackColor = Color.Blue;
                    if (textBox3.Text == listBox1.Items[2].ToString())
                        label3.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox4.Text))
                        label4.BackColor = Color.Blue;
                    if (textBox4.Text == listBox1.Items[3].ToString())
                        label4.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox5.Text))
                        label5.BackColor = Color.Blue;
                    if (textBox5.Text == listBox1.Items[4].ToString())
                        label5.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox6.Text))
                        label6.BackColor = Color.Blue;
                    if (textBox6.Text == listBox1.Items[5].ToString())
                        label6.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox7.Text))
                        label7.BackColor = Color.Blue;
                    if (textBox7.Text == listBox1.Items[6].ToString())
                        label7.BackColor = Color.Green;
                }
                if (label1.BackColor == Color.Green &&
                    label2.BackColor == Color.Green &&
                    label3.BackColor == Color.Green &&
                    label4.BackColor == Color.Green &&
                    label5.BackColor == Color.Green &&
                    label6.BackColor == Color.Green &&
                    label7.BackColor == Color.Green)
                {
                    timer1.Stop();
                    timer2.Stop();
                    kaydet();
                    MessageBox.Show("KAZANDINIZ PUANINIZ: " + labelGeriSayim.Text);
                    oku();
                    groupBox2.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;
                }
                if (tiklanma == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    sayac = 0;
                    kaydet();
                    MessageBox.Show("HAKKINIZ BİTTİ. TEKRAR DENEYİN.. ÜRETİLEN SAYI: " + label10.Text + " idi");
                    oku();
                    tiklanma = 5;
                    groupBox2.Visible = false;
                    label11.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;

                }
                // tikla();
                tiklanma--;
                label11.Text = tiklanma + " HAKKINIZ KALDI";
            }
            if (textBoxUzunluk.Text == "8")
            {
                label11.Text = tiklanma + " HAKKINIZ KALDI";
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                label5.BackColor = Color.Red;
                label6.BackColor = Color.Red;
                label7.BackColor = Color.Red;
                label7.BackColor = Color.Red;



                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox1.Text))
                        label1.BackColor = Color.Blue;
                    if (textBox1.Text == listBox1.Items[0].ToString())
                        label1.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox2.Text))
                        label2.BackColor = Color.Blue;
                    if (textBox2.Text == listBox1.Items[1].ToString())
                        label2.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox3.Text))
                        label3.BackColor = Color.Blue;
                    if (textBox3.Text == listBox1.Items[2].ToString())
                        label3.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox4.Text))
                        label4.BackColor = Color.Blue;
                    if (textBox4.Text == listBox1.Items[3].ToString())
                        label4.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox5.Text))
                        label5.BackColor = Color.Blue;
                    if (textBox5.Text == listBox1.Items[4].ToString())
                        label5.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox6.Text))
                        label6.BackColor = Color.Blue;
                    if (textBox6.Text == listBox1.Items[5].ToString())
                        label6.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox7.Text))
                        label7.BackColor = Color.Blue;
                    if (textBox7.Text == listBox1.Items[6].ToString())
                        label7.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox8.Text))
                        label8.BackColor = Color.Blue;
                    if (textBox8.Text == listBox1.Items[7].ToString())
                        label8.BackColor = Color.Green;
                }
                if (label1.BackColor == Color.Green &&
                   label2.BackColor == Color.Green &&
                   label3.BackColor == Color.Green &&
                   label4.BackColor == Color.Green &&
                   label5.BackColor == Color.Green &&
                   label6.BackColor == Color.Green &&
                   label7.BackColor == Color.Green &&
                   label8.BackColor == Color.Green)
                {
                    timer1.Stop();
                    timer2.Stop();
                    kaydet();
                    MessageBox.Show("KAZANDINIZ PUANINIZ: " + labelGeriSayim.Text);
                    oku();
                    groupBox2.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;
                }

                if (tiklanma == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    sayac = 0;
                    kaydet();
                    MessageBox.Show("HAKKINIZ BİTTİ. TEKRAR DENEYİN.. ÜRETİLEN SAYI: " + label10.Text + " idi");
                    oku();
                    tiklanma = 5;
                    groupBox2.Visible = false;
                    label11.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;

                }
              //  tikla();
                tiklanma--;
                label11.Text = tiklanma + " HAKKINIZ KALDI";
            }
            if (textBoxUzunluk.Text == "9")
            {
                label11.Text = tiklanma + " HAKKINIZ KALDI";
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                label5.BackColor = Color.Red;
                label6.BackColor = Color.Red;
                label7.BackColor = Color.Red;
                label8.BackColor = Color.Red;
                label9.BackColor = Color.Red;




                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox1.Text))
                        label1.BackColor = Color.Blue;
                    if (textBox1.Text == listBox1.Items[0].ToString())
                        label1.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox2.Text))
                        label2.BackColor = Color.Blue;
                    if (textBox2.Text == listBox1.Items[1].ToString())
                        label2.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox3.Text))
                        label3.BackColor = Color.Blue;
                    if (textBox3.Text == listBox1.Items[2].ToString())
                        label3.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox4.Text))
                        label4.BackColor = Color.Blue;
                    if (textBox4.Text == listBox1.Items[3].ToString())
                        label4.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox5.Text))
                        label5.BackColor = Color.Blue;
                    if (textBox5.Text == listBox1.Items[4].ToString())
                        label5.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox6.Text))
                        label6.BackColor = Color.Blue;
                    if (textBox6.Text == listBox1.Items[5].ToString())
                        label6.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox7.Text))
                        label7.BackColor = Color.Blue;
                    if (textBox7.Text == listBox1.Items[6].ToString())
                        label7.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox8.Text))
                        label8.BackColor = Color.Blue;
                    if (textBox8.Text == listBox1.Items[7].ToString())
                        label8.BackColor = Color.Green;
                }
                foreach (string item in listBox1.Items)
                {
                    if (item.Contains(textBox8.Text))
                        label9.BackColor = Color.Blue;
                    if (textBox9.Text == listBox1.Items[8].ToString())
                        label9.BackColor = Color.Green;
                }
                if (label1.BackColor == Color.Green &&
                    label2.BackColor == Color.Green &&
                    label3.BackColor == Color.Green &&
                    label4.BackColor == Color.Green &&
                    label5.BackColor == Color.Green &&
                    label6.BackColor == Color.Green &&
                    label7.BackColor == Color.Green &&
                    label8.BackColor == Color.Green &&
                    label9.BackColor == Color.Green)
                {
                    timer1.Stop();
                    timer2.Stop();
                    kaydet();
                    MessageBox.Show("KAZANDINIZ PUANINIZ: " + labelGeriSayim.Text);
                    oku();
                    groupBox2.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;

                    
                }
                if (tiklanma == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    sayac = 0;
                    kaydet();
                    MessageBox.Show("HAKKINIZ BİTTİ. TEKRAR DENEYİN.. ÜRETİLEN SAYI: " + label10.Text + " idi");
                    oku();
                    tiklanma = 5;
                    groupBox2.Visible = false;
                    label11.Visible = false;
                    sayac = 100;
                    BtnSayiUret.Enabled = true;
                    groupBox1.Visible = true;
                }
                //tikla();
                tiklanma--;
                label11.Text = tiklanma + " HAKKINIZ KALDI";

            }


        }

        private void BtnSayiUret_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBoxUzunluk.Text == "")
            {
                MessageBox.Show("LÜTFEN BOYUTU BELİRLEYİN");
            }
            else
            {
                
                if (Convert.ToInt32(textBoxUzunluk.Text) < 1 || Convert.ToInt32(textBoxUzunluk.Text) > 9)
                {
                    MessageBox.Show("1 ile 9 arasında bir uzunluk gir");
                }

                else
                {MessageBox.Show("TOPLAM 5 HAKKINIZ VAR. 5 HAKTA DA BİLEMEZSENİZ SIFIR PUAN ALIRSINIZ");
                BtnSayiUret.Enabled = false;
                groupBox1.Visible = false;
                    groupBox2.Visible = true;
                label11.Text = besHak;
                tiklanma = 5;
                timer1.Start();
                    timer2.Start();
                    
                    label10.Text = "";
                    s1 = int.Parse(textBoxUzunluk.Text);
                    s1 = Convert.ToInt32(Math.Pow(10, s1));
                    s1 = s1 - 1;
                    s2 = Convert.ToInt32(Math.Pow(10, Convert.ToInt32(textBoxUzunluk.Text) - 1));

                    Random rnd = new Random();
                    s3 = rnd.Next(s2, s1);
                    label10.Text = s3.ToString();
                    s4 = label10.Text.Length;
                    string hane = s4.ToString();

                    Char[] Rakamlar(string girilensayi)
                    {
                        Char[] D = girilensayi.ToCharArray();
                        return D;
                    }
                    Char[] Ilk = Rakamlar(label10.Text);
                    foreach (Char Basamak in Ilk)
                    {
                        listBox1.Items.Add(Basamak.ToString());
                    }
                }
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                if (s4 == 1)
                {
                    textBox1.Visible = true;
                    label1.Visible = true;
                    label11.Visible = true;


                }
                if (s4 == 2)
                {

                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label11.Visible = true;
                }
                if (s4 == 3)
                {
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label11.Visible = true;
                }
                if (s4 == 4)
                {
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label11.Visible = true;
                }
                if (s4 == 5)
                {
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label11.Visible = true;


                }
                if (s4 == 6)
                {
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label11.Visible = true;


                }
                if (s4 == 7)
                {
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label11.Visible = true;


                }
                if (s4 == 8)
                {
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label11.Visible = true;
                }
                if (s4 == 9)
                {
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label11.Visible = true;
                }
                if (radioTekrarsiz.Checked)
                {
                    listBox1.Items.Clear();
                olustur:
                    Random rs = new Random();
                    int sayi1 = rs.Next(1, 10),
                        sayi2 = rs.Next(0, 10),
                        sayi3 = rs.Next(0, 10),
                        sayi4 = rs.Next(0, 10),
                        sayi5 = rs.Next(0, 10),
                        sayi6 = rs.Next(0, 10),
                        sayi7 = rs.Next(0, 10),
                        sayi8 = rs.Next(0, 10),
                        sayi9 = rs.Next(0, 10);
                    if (sayi1 == sayi2 || sayi1 == sayi3 || sayi1 == sayi4 || sayi1 == sayi5 || sayi1 == sayi6 || sayi1 == sayi7 || sayi1 == sayi8 || sayi1 == sayi9 ||
                       sayi2 == sayi3 || sayi2 == sayi4 || sayi2 == sayi5 || sayi2 == sayi6 || sayi2 == sayi7 || sayi2 == sayi8 || sayi2 == sayi9 ||
                       sayi3 == sayi4 || sayi3 == sayi5 || sayi3 == sayi6 || sayi3 == sayi7 || sayi3 == sayi8 || sayi3 == sayi9 ||
                       sayi4 == sayi5 || sayi4 == sayi6 || sayi4 == sayi7 || sayi4 == sayi8 || sayi4 == sayi9 ||
                       sayi5 == sayi6 || sayi5 == sayi7 || sayi5 == sayi8 || sayi5 == sayi9 ||
                       sayi6 == sayi7 || sayi6 == sayi8 || sayi6 == sayi9 ||
                       sayi7 == sayi8 || sayi7 == sayi9 ||
                       sayi8 == sayi9)
                    {
                        goto olustur;
                    }
                    else
                    {
                        if (textBoxUzunluk.Text == "1")
                        {
                            label10.Text = sayi1.ToString();
                            textBox1.Visible = true;
                            label1.Visible = true;
                            groupBox2.Visible = true;
                        }
                        if (textBoxUzunluk.Text == "2")
                        {
                            label10.Text = sayi1 + "" + sayi2;
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            label1.Visible = true;
                            label2.Visible = true;
                            groupBox2.Visible = true;
                        }
                        if (textBoxUzunluk.Text == "3")
                        {
                            label10.Text = sayi1 + "" + sayi2 + "" + sayi3;
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            label1.Visible = true;
                            label2.Visible = true;
                            label3.Visible = true;
                            groupBox2.Visible = true;
                        }
                        if (textBoxUzunluk.Text == "4")
                        {
                            label10.Text = sayi1 + "" + sayi2 + "" + sayi3 + "" + sayi4;
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            textBox4.Visible = true;
                            label1.Visible = true;
                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            groupBox2.Visible = true;
                        }
                        if (textBoxUzunluk.Text == "5")
                        {
                            label10.Text = sayi1 + "" + sayi2 + "" + sayi3 + "" + sayi4 + "" + sayi5;
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            textBox4.Visible = true;
                            textBox5.Visible = true;
                            label1.Visible = true;
                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            groupBox2.Visible = true;
                        }
                        if (textBoxUzunluk.Text == "6")
                        {
                            label10.Text = sayi1 + "" + sayi2 + "" + sayi3 + "" + sayi4 + "" + sayi5 + "" + sayi6;
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            textBox4.Visible = true;
                            textBox5.Visible = true;
                            textBox6.Visible = true;
                            label1.Visible = true;
                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            label6.Visible = true;
                            groupBox2.Visible = true;
                        }
                        if (textBoxUzunluk.Text == "7")
                        {
                            label10.Text = sayi1 + "" + sayi2 + "" + sayi3 + "" + sayi4 + "" + sayi5 + "" + sayi6 + "" + sayi7;
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            textBox4.Visible = true;
                            textBox5.Visible = true;
                            textBox6.Visible = true;
                            textBox7.Visible = true;
                            label1.Visible = true;
                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            label6.Visible = true;
                            label7.Visible = true;
                            groupBox2.Visible = true;
                        }
                        if (textBoxUzunluk.Text == "8")
                        {
                            label10.Text = sayi1 + "" + sayi2 + "" + sayi3 + "" + sayi4 + "" + sayi5 + "" + sayi6 + "" + sayi7 + "" + sayi8;
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            textBox4.Visible = true;
                            textBox5.Visible = true;
                            textBox6.Visible = true;
                            textBox7.Visible = true;
                            textBox8.Visible = true;
                            label1.Visible = true;
                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            label6.Visible = true;
                            label7.Visible = true;
                            label8.Visible = true;
                            groupBox2.Visible = true;
                        }
                        if (textBoxUzunluk.Text == "9")
                        {
                            label10.Text = sayi1 + "" + sayi2 + "" + sayi3 + "" + sayi4 + "" + sayi5 + "" + sayi6 + "" + sayi7 + "" + sayi8 + "" + sayi9;
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            textBox4.Visible = true;
                            textBox5.Visible = true;
                            textBox6.Visible = true;
                            textBox7.Visible = true;
                            textBox8.Visible = true;
                            textBox9.Visible = true;
                            label1.Visible = true;
                            label2.Visible = true;
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            label6.Visible = true;
                            label7.Visible = true;
                            label8.Visible = true;
                            label9.Visible = true;
                            groupBox2.Visible = true;

                        }
                        Char[] Rakamlar(string girilensayi)
                        {
                            Char[] D = girilensayi.ToCharArray();
                            return D;
                        }
                        Char[] Ilk = Rakamlar(label10.Text);
                        foreach (Char Basamak in Ilk)
                        {
                            listBox1.Items.Add(Basamak.ToString());
                        }
                    }

                }

                label1.BackColor = Color.DimGray;
                label2.BackColor = Color.DimGray;
                label3.BackColor = Color.DimGray;
                label4.BackColor = Color.DimGray;
                label5.BackColor = Color.DimGray;
                label6.BackColor = Color.DimGray;
                label7.BackColor = Color.DimGray;
                label8.BackColor = Color.DimGray;
                label9.BackColor = Color.DimGray;
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
               


            }
        }

    }
}

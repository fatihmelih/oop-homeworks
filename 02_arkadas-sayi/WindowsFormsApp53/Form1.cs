/*****************************************************************************
**					SAKARYA ÜNİVERSİTESİ                                    **
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                   **
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                          **
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ                         **
**					2019-2020 BAHAR DÖNEMİ                                  **
**	                                                                        **
**				ÖDEV NUMARASI..........: 2                                  **
**				ÖĞRENCİ ADI............: FATIH MELIH ERSOY                  **
**				ÖĞRENCİ NUMARASI.......: B181210101                         **
**              DERSİN ALINDIĞI GRUP...: D                                  **
*****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextBox textBox3 = new TextBox();
        TextBox textBox4 = new TextBox();
        ListBox listBox1 = new ListBox();
        ListBox listBox2 = new ListBox();
        Label label3 = new Label();
        Label label4 = new Label();
        public void button1_Click(object sender, EventArgs e)
        {
            this.Height = 269;this.Width = 614;

            label3.Name = "label3" + 0;
            label3.Text = "X";
            label3.Location = new System.Drawing.Point(337, 8);
            label3.Size = new System.Drawing.Size(100, 25);

            label4.Name = "label4" + 0;
            label4.Text = "Y";
            label4.Location = new System.Drawing.Point(471, 8);
            label4.Size = new System.Drawing.Size(100, 25);

            textBox3.Name = "textBox3" + 0;
            textBox3.Location = new System.Drawing.Point(317, 180);
            textBox3.Size = new System.Drawing.Size(100, 25);
            
            textBox4.Name = "textBox4" + 0;
            textBox4.Location = new System.Drawing.Point(451, 180);
            textBox4.Size = new System.Drawing.Size(100, 25);
            
            listBox1.Name = "listBox1" + 0;
            listBox1.Location = new System.Drawing.Point(317, 26);
            listBox1.Size = new System.Drawing.Size(100, 134);
            
            listBox2.Name = "listBox2" + 0;
            listBox2.Location = new System.Drawing.Point(451, 26);
            listBox2.Size = new System.Drawing.Size(100, 134);

            this.Controls.Add(textBox3);
            this.Controls.Add(textBox4);
            this.Controls.Add(listBox1);
            this.Controls.Add(listBox2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);

            carpanlaraAyirX(x);
            carpanlaraAyirY(y);
        }

        private void carpanlaraAyirX(int sayi1)
        {
            int b = 1;
            int toplam = 0;
            for (int i = 1; i < sayi1; i++)
            {
                if (sayi1 % b == 0)
                {
                    listBox1.Items.Add(b.ToString());
                    toplam += b;
                    b++;

                }
                else
                {
                    b++;
                }
            }
            textBox3.Text = toplam.ToString();
        }

        private void carpanlaraAyirY(int sayi2)
        {
            int b = 1;
            int toplam = 0;
            for (int i = 1; i < sayi2; i++)
            {
                if (sayi2 % b == 0)
                {
                    listBox2.Items.Add(b.ToString());
                    toplam += b;
                    b++;

                }
                else
                {
                    b++;
                }
            }
            textBox4.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

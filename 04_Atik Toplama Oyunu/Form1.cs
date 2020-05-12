/*****************************************************************************
**					SAKARYA ÜNİVERSİTESİ                                    **
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                   **
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                          **
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ                         **
**	                       PROJE ÖDEVİ                                      **
**				                                                            **
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

namespace WindowsFormsApp2
{
    public interface IAtik
    {
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }

    public interface IAtikKutusu : IDolabilen
    {
        int BosaltmaPuani { get; }
        bool Ekle(Atik atik);
        bool Bosalt();

    }

    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        int puan = 0;
        int zaman = 60;

        public static Atik CamSise = new Atik("camsise", 600);
        public static Atik Bardak = new Atik("bardak", 250);
        public static Atik Gazete = new Atik("gazete", 250);
        public static Atik Dergi = new Atik("dergi", 200);
        public static Atik Domates = new Atik("domates", 150);
        public static Atik Salatalik = new Atik("salatalik", 120);
        public static Atik KolaKutusu = new Atik("kolakutusu", 350);
        public static Atik SalcaKutusu = new Atik("salcakutusu", 550);

        AtikKutusu OrganikAtikKutusu = new AtikKutusu(0, 700);
        AtikKutusu KagitKutusu = new AtikKutusu(1000, 1200);
        AtikKutusu CamKutusu = new AtikKutusu(600, 2200);
        AtikKutusu MetalKutusu = new AtikKutusu(800, 2300);

        public static string[] secim = {
                            CamSise.atikIsmi,
                            Bardak.atikIsmi,
                            Gazete.atikIsmi,
                            Dergi.atikIsmi,
                            Domates.atikIsmi,
                            Salatalik.atikIsmi,
                            KolaKutusu.atikIsmi,
                            SalcaKutusu.atikIsmi};

        public static string[] fotografSecim = {
                            "camsise.png",
                            "bardak.png",
                            "gazete.png",
                            "dergi.png",
                            "domates.png",
                            "salatalik.png",
                            "kolakutusu.png",
                            "salcakutusu.png"
                            };


        public static Random rnd = new Random();
        public static int rasgele;



        public void button1_Click(object sender, EventArgs e)
        {
            rasgele = rnd.Next(0, secim.Length);
            listBox1.Items.Clear();
            OrganikAtikKutusu.DolulukOrani = 0;
            OrganikAtikKutusu.DoluHacim = 0;
            progressBar1.Value = 0;
            listBox2.Items.Clear();
            KagitKutusu.DolulukOrani = 0;
            KagitKutusu.DoluHacim = 0;
            progressBar2.Value = 0;
            listBox3.Items.Clear();
            CamKutusu.DolulukOrani = 0;
            CamKutusu.DoluHacim = 0;
            progressBar3.Value = 0;
            listBox4.Items.Clear();
            MetalKutusu.DolulukOrani = 0;
            MetalKutusu.DoluHacim = 0;
            progressBar4.Value = 0;

            pictureBox1.Image = Image.FromFile(fotografSecim[rasgele]);
            puan = 0;
            zaman = 60;
            label1.Text = zaman.ToString();
            timer1.Start();         
            button1.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            if (secim[rasgele] == "domates")
            {
                             
                if (OrganikAtikKutusu.DoluHacim + Domates.Hacim <= 700)
                {
                    OrganikAtikKutusu.Ekle(Domates);
                    listBox1.Items.Add("Domates (150)");
                    puan += Domates.Hacim;
                    progressBar1.Value = OrganikAtikKutusu.DolulukOrani;
                    rasgele = rnd.Next(0, secim.Length);
                    pictureBox1.Image = Image.FromFile(fotografSecim[rasgele]);
                }
            }

            else if(secim[rasgele] == "salatalik")
            { 
                if(OrganikAtikKutusu.DoluHacim + Salatalik.Hacim < 700)
                {
                    OrganikAtikKutusu.Ekle(Salatalik);
                    listBox1.Items.Add("Salatalık (120)");
                    puan += Salatalik.Hacim;
                    progressBar1.Value = OrganikAtikKutusu.DolulukOrani;
                    rasgele = rnd.Next(0, secim.Length);
                    pictureBox1.Image = Image.FromFile(fotografSecim[rasgele]);
                }
                
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            progressBar2.Step = 1;

            if (secim[rasgele] == "gazete")
            {

                if ((KagitKutusu.DoluHacim + Gazete.Hacim) < 1200)
                {
                    KagitKutusu.Ekle(Gazete);
                    listBox2.Items.Add("Gazete (250)");
                    puan += Gazete.Hacim;
                    progressBar2.Value = KagitKutusu.DolulukOrani;
                    rasgele = rnd.Next(0, secim.Length);
                    pictureBox1.Image = Image.FromFile(fotografSecim[rasgele]);
                }
            }

            else if (secim[rasgele] == "dergi")
            {
                if ((KagitKutusu.DoluHacim + Dergi.Hacim) < 1200)
                {
                    KagitKutusu.Ekle(Dergi);
                    listBox2.Items.Add("Dergi (200)");
                    puan += Dergi.Hacim;
                    progressBar2.Value = KagitKutusu.DolulukOrani;
                    rasgele = rnd.Next(0, secim.Length);
                    pictureBox1.Image = Image.FromFile(fotografSecim[rasgele]);
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 100;
            progressBar3.Step = 1;

            if (secim[rasgele] == "camsise")
            {

                if (CamKutusu.DoluHacim + CamSise.Hacim < 2200)
                {
                    CamKutusu.Ekle(CamSise);
                    listBox3.Items.Add("Cam Şişe (600)");
                    puan += CamSise.Hacim;
                    progressBar3.Value = CamKutusu.DolulukOrani;
                    rasgele = rnd.Next(0, secim.Length);
                    pictureBox1.Image = Image.FromFile(fotografSecim[rasgele]);
                }
            }

            else if (secim[rasgele] == "bardak")
            {
                if (CamKutusu.DoluHacim + Bardak.Hacim < 2200)
                {
                    CamKutusu.Ekle(Bardak);
                    listBox3.Items.Add("Bardak (250)");
                    puan += Bardak.Hacim;
                    progressBar3.Value = CamKutusu.DolulukOrani;
                    rasgele = rnd.Next(0, secim.Length);
                    pictureBox1.Image = Image.FromFile(fotografSecim[rasgele]);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            progressBar4.Minimum = 0;
            progressBar4.Maximum = 100;
            progressBar4.Step = 1;


            if (secim[rasgele] == "kolakutusu")
            {

                if (MetalKutusu.DoluHacim + KolaKutusu.Hacim < 2300)
                {
                    MetalKutusu.Ekle(KolaKutusu);
                    listBox4.Items.Add("Kola Kutusu (350)");
                    puan += KolaKutusu.Hacim;
                    progressBar4.Value = MetalKutusu.DolulukOrani;
                    rasgele = rnd.Next(0, secim.Length);
                    pictureBox1.Image = Image.FromFile(fotografSecim[rasgele]);
                }
            }

            else if (secim[rasgele] == "salcakutusu")
            {
                if (MetalKutusu.DoluHacim + SalcaKutusu.Hacim <= 2300)
                {
                    MetalKutusu.Ekle(SalcaKutusu);
                    listBox4.Items.Add("Salça Kutusu (550)");
                    puan += SalcaKutusu.Hacim;
                    progressBar4.Value = MetalKutusu.DolulukOrani;                  
                    rasgele = rnd.Next(0, secim.Length);
                    pictureBox1.Image = Image.FromFile(fotografSecim[rasgele]);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(OrganikAtikKutusu.DolulukOrani>=75)
            {
                listBox1.Items.Clear();
                OrganikAtikKutusu.DolulukOrani = 0;
                OrganikAtikKutusu.DoluHacim = 0;
                progressBar1.Value = 0;
                puan += 0;
                zaman += 3;
                label2.Text = puan.ToString();
            }
                
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(KagitKutusu.DolulukOrani>=75)
            {
                listBox2.Items.Clear();
                KagitKutusu.DolulukOrani = 0;
                KagitKutusu.DoluHacim = 0;
                progressBar2.Value = 0;
                puan += 1000;
                zaman += 3;
                label2.Text = puan.ToString();
            }
                
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(CamKutusu.DolulukOrani>=75)
            {
                listBox3.Items.Clear();
                CamKutusu.DolulukOrani = 0;
                CamKutusu.DoluHacim = 0;
                progressBar3.Value = 0;
                puan += 600;
                zaman += 3;
                label2.Text = puan.ToString();
            }
               
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(MetalKutusu.DolulukOrani>=75)
            {
                listBox4.Items.Clear();
                MetalKutusu.DolulukOrani = 0;
                MetalKutusu.DoluHacim = 0;
                progressBar4.Value = 0;
                puan += 800;
                zaman += 3;
                label2.Text = puan.ToString();
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            zaman--;
            label1.Text = zaman.ToString();
            label2.Text = puan.ToString();


            if (zaman == 0)
            {
                timer1.Stop();
                button1.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

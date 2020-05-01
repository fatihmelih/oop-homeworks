/*****************************************************************************
**					SAKARYA ÜNİVERSİTESİ                                    **
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                   **
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                          **
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ                         **
**					2019-2020 BAHAR DÖNEMİ                                  **
**	                                                                        **
**				ÖDEV NUMARASI..........: 3                                  **
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

namespace WindowsFormsApp52
{
    public partial class Form1 : Form
    {

        Buzdolabi buz = new Buzdolabi(3500);
        LedTv led = new LedTv(4000);
        CepTel cep = new CepTel(2500);
        Laptop lap = new Laptop(6000);


        public Form1()
        {
            InitializeComponent();
            label14.Text = buz.StokAdedi.ToString();
            label15.Text = led.StokAdedi.ToString();
            label16.Text = cep.StokAdedi.ToString();
            label17.Text = lap.StokAdedi.ToString();
            label18.Text = buz.HamFiyat.ToString();
            label19.Text = led.HamFiyat.ToString();
            label20.Text = cep.HamFiyat.ToString();
            label21.Text = lap.HamFiyat.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); listBox2.Items.Clear(); listBox3.Items.Clear();
            buz.SecilenAdet = Convert.ToInt32(numericUpDown1.Value);
            led.SecilenAdet = Convert.ToInt32(numericUpDown2.Value);
            cep.SecilenAdet = Convert.ToInt32(numericUpDown3.Value);
            lap.SecilenAdet = Convert.ToInt32(numericUpDown4.Value);
            listBox3.Items.Add(buz.KdvUygula(buz.SecilenAdet));
            listBox3.Items.Add(led.KdvUygula(led.SecilenAdet));
            listBox3.Items.Add(cep.KdvUygula(cep.SecilenAdet));
            listBox3.Items.Add(lap.KdvUygula(lap.SecilenAdet));
            listBox1.Items.Add(buz.SecilenAdet);
            listBox1.Items.Add(led.SecilenAdet);
            listBox1.Items.Add(cep.SecilenAdet);
            listBox1.Items.Add(lap.SecilenAdet);
            listBox2.Items.Add("Buzdolabı");
            listBox2.Items.Add("Led Tv");
            listBox2.Items.Add("Cep Telefonu");
            listBox2.Items.Add("Laptop");
            label14.Text = (buz.StokAdedi-buz.SecilenAdet).ToString();
            label15.Text = (led.StokAdedi - led.SecilenAdet).ToString();
            label16.Text = (cep.StokAdedi - cep.SecilenAdet).ToString();
            label17.Text = (lap.StokAdedi - lap.SecilenAdet).ToString();
            label25.Text = (buz.KdvUygula(buz.SecilenAdet)+ led.KdvUygula(led.SecilenAdet)+ cep.KdvUygula(cep.SecilenAdet)+ lap.KdvUygula(lap.SecilenAdet)).ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); listBox2.Items.Clear(); listBox3.Items.Clear();
            label25.Text = "";
            label14.Text = buz.StokAdedi.ToString();
            label15.Text = led.StokAdedi.ToString();
            label16.Text = cep.StokAdedi.ToString();
            label17.Text = lap.StokAdedi.ToString();
        }
    }
}

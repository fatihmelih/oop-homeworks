/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ                                   **
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                  **
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                         **
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ                        **
**	                                                                       **
**				    ÖDEV NUMARASI..........: 1                             **
**				    ÖĞRENCİ ADI............: FATIH MELIH ERSOY             **
**				    ÖĞRENCİ NUMARASI.......: B181210101                    **
**                  DERSİN ALINDIĞI GRUP...: D                             **
**                                                                         **
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp26
{
    class ogrenci
    {
        public string[] studentData = new string[100];
        public string[] name = new string[100];
        public string[] surname = new string[100];
        public int[] number = new int[100];
        public int[] visa1 = new int[100];
        public int[] homework = new int[100];
        public int[] finalexam = new int[100];
        public string[] harfnotu = new string[100];
        public double[] ortalama = new double[100];
        char[] ayrac = { ' ' };
        string[] parcalar = new string[6];

        public void parcalaridiz(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                parcalar = studentData[i].Split(ayrac);
                name[i] = parcalar[0];
                surname[i] = parcalar[1];
                number[i] = Convert.ToInt32(parcalar[2]);
                visa1[i] = Convert.ToInt32(parcalar[3]);
                homework[i] = Convert.ToInt32(parcalar[4]);
                finalexam[i] = Convert.ToInt32(parcalar[5]);
            }

        }

        public void ortalamaHesapla(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                ortalama[i] = homework[i] * 0.1 + visa1[i] * 0.3 + finalexam[i] * 0.5;
            }
        }

        public void harfNotuHesapla(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                if (ortalama[i] <= 100 && ortalama[i] >= 90)
                    harfnotu[i] = "AA";
                else if (ortalama[i] <= 89.99 && ortalama[i] >= 85)
                    harfnotu[i] = "BA";
                else if (ortalama[i] <= 84.99 && ortalama[i] >= 80)
                    harfnotu[i] = "BB";
                else if (ortalama[i] <= 79.99 && ortalama[i] >= 75)
                    harfnotu[i] = "CB";
                else if (ortalama[i] <= 74.99 && ortalama[i] >= 65)
                    harfnotu[i] = "CC";
                else if (ortalama[i] <= 64.99 && ortalama[i] >= 58)
                    harfnotu[i] = "DC";
                else if (ortalama[i] <= 57.99 && ortalama[i] >= 50)
                    harfnotu[i] = "DD";
                else if (ortalama[i] <= 49.99 && ortalama[i] >= 40)
                    harfnotu[i] = "FD";
                else if (ortalama[i] <= 39.99 && ortalama[i] >= 0)
                    harfnotu[i] = "FF";
                else
                    Console.WriteLine("HARF NOTU YOK!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(DateTime.Now.Second);

            string[] namesurname = {"Liam","Smith","Emma",
            "Johnson","Noah","Williams","Olivia","Brown","William",
            "King","Rick","Front"};

            string fileName = "firstdata.txt";

            FileStream fs = File.Create(fileName);
            fs.Close();

            StreamWriter yazz = new StreamWriter(fileName);
            for (int i = 0; i < 100; i++)
            {
                yazz.WriteLine(namesurname[rand.Next(0, namesurname.Length - 1)] + " " + 
                    namesurname[rand.Next(0, namesurname.Length - 1)] + " " + 
                    rand.Next(1,9999) + " " + rand.Next(0, 100) + " " + rand.Next(0, 100) + " " + rand.Next(0, 100) + " " + rand.Next(0, 100));
            }
            yazz.Close();


            string DosyaYolu1 = "firstdata.txt";
            if (File.Exists(DosyaYolu1))
            {
                Console.Write("Ödevler %10  Vize %30  Final %50  etkiliyor\n\n");
                int ogrenciSayisi = 100;
                StreamReader Read = new StreamReader(DosyaYolu1);
                ogrenci ogr = new ogrenci();

                int i = 0;
                while (!Read.EndOfStream)
                {
                    ogr.studentData[i] = Read.ReadLine();
                    i++;
                }
                Read.Close();

                ogr.parcalaridiz(ogrenciSayisi);
                ogr.ortalamaHesapla(ogrenciSayisi);
                ogr.harfNotuHesapla(ogrenciSayisi);

                for (int k = 0; k < i; k++)
                {
                    Console.WriteLine("\n" + "Adı...:{0}" + "   " +
                        "Soyadı :{1}" + "   " +
                        "Numara: {2}" + "   " +
                        "Vize :{3}" + "   " +
                        "Ödev :{4}" + "   " +
                        "Final :{5}" + "   " +
                        "ORTALAMA :{6}" + "   " +
                        "HARF NOTU :{7}" + "\n",
                        ogr.name[k], ogr.surname[k], ogr.number[k], ogr.visa1[k], ogr.homework[k], ogr.finalexam[k], ogr.ortalama[k], ogr.harfnotu[k]);
                }
                int AA = 0, BA = 0, BB = 0, CB = 0, CC = 0, DC = 0, DD = 0, FD = 0, FF = 0;
                double HT = 0;
                for (int l = 0; l < i; l++)
                {
                    switch (ogr.harfnotu[l])
                    {
                        case "AA":
                            AA++;
                            HT++;
                            break;
                        case "BA":
                            BA++;
                            HT++;
                            break;
                        case "BB":
                            BB++;
                            HT++;
                            break;
                        case "CB":
                            CB++;
                            HT++;
                            break;
                        case "CC":
                            CC++;
                            HT++;
                            break;
                        case "DC":
                            DC++;
                            HT++;
                            break;
                        case "DD":
                            DD++;
                            HT++;
                            break;
                        case "FD":
                            FD++;
                            HT++;
                            break;
                        case "FF":
                            FF++;
                            HT++;
                            break;
                        default:
                            break;
                    }
                }

                ConsoleKeyInfo cki;
                ConsoleKeyInfo keyinfo;
                Console.WriteLine("\nISTATISTIKLARI GORUNTULEMEK ICIN 'E' TUSUNA BASINIZ\n");
                keyinfo = Console.ReadKey(true);
                if (keyinfo.KeyChar == Convert.ToChar(ConsoleKey.E))
                {
                    Console.WriteLine("\n" + "AA alan {0} ogrenci var" + "   " + "%{9} " + "\n" +
                    "BA alan {1} ogrenci var" + "   " + "%{10}" + "\n" +
                    "BB alan {2} ogrenci var" + "   " + "%{11}" + "\n" +
                    "CB alan {3} ogrenci var" + "   " + "%{12}" + "\n" +
                    "CC alan {4} ogrenci var" + "   " + "%{13}" + "\n" +
                    "DC alan {5} ogrenci var" + "   " + "%{14}" + "\n" +
                    "DD alan {6} ogrenci var" + "   " + "%{15}" + "\n" +
                    "FD alan {7} ogrenci var" + "   " + "%{16}" + "\n" +
                    "FF alan {8} ogrenci var" + "   " + "%{17}" + "\n\n" +
                    "Gecen ogrenci sayisi : " + "   " + "{18}" + "\n" +
                    "Kalan ogrenci sayisi : " + "   " + "{19}" + "\n\n" +
                    "sonuclar.txt dosyasi bulunursa istatistikler kaydedilecektir."
                    , AA, BA, BB, CB, CC, DC, DD, FD, FF, AA / HT * 100, BA / HT * 100, BB / HT * 100, CB / HT * 100, CC / HT * 100, 
                    DC / HT * 100, DD / HT * 100, FD / HT * 100, FF / HT * 100, AA + BA + BB + CB + CC, DC + DD + FD + FF);
                    
                    FileStream fsss = File.Create("sonuclar.txt");
                    fsss.Close();
                    string DosyaYolu2 = "sonuclar.txt";
                        Console.WriteLine("sonuclar.txt dosyasina kayit yapildi.\n\n");
                        StreamWriter Yaz = new StreamWriter("sonuclar.txt");
                        Yaz.WriteLine("AA alan {0} ogrenci var" + "   " + "%{9} " + "\n" +
                        "BA alan {1} ogrenci var" + "   " + "%{10}" + "\n" +
                        "BB alan {2} ogrenci var" + "   " + "%{11}" + "\n" +
                        "CB alan {3} ogrenci var" + "   " + "%{12}" + "\n" +
                        "CC alan {4} ogrenci var" + "   " + "%{13}" + "\n" +
                        "DC alan {5} ogrenci var" + "   " + "%{14}" + "\n" +
                        "DD alan {6} ogrenci var" + "   " + "%{15}" + "\n" +
                        "FD alan {7} ogrenci var" + "   " + "%{16}" + "\n" +
                        "FF alan {8} ogrenci var" + "   " + "%{17}" + "\n\n" +
                        "Gecen ogrenci sayisi : " + "   " + "%{18}" + "\n" +
                        "Kalan ogrenci sayisi : " + "   " + "%{19}"
                        , AA, BA, BB, CB, CC, DC, DD, FD, FF, AA / HT * 100, BA / HT * 100, BB / HT * 100, CB / HT * 100, 
                        CC / HT * 100, DC / HT * 100, DD / HT * 100, FD / HT * 100, FF / HT * 100, AA + BA + BB + CB + CC, DC + DD + FD + FF);
                        Yaz.Close();
                }
            }            
        }
    }
}
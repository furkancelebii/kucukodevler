/***************************************************************
 **                                                                             SAKARYA ÜNİVERSİTESİ
 **                                                                   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                                                                       BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 **                                                                      NESNEYE DAYALI PROGRAMLAMA DERSİ
 **                                                                          2020-2021 BAHAR DÖNEMİ
 **
 **                                                                         ÖDEV NUMARASI.......:1
 **                                                                         ÖĞRENCİ NUMARASI....:G191210033
 **                                                                         ÖĞRENCİ ADI.........:MAZHAR FURKAN ÇELEBİ
 **                                                                         DERSİN ALINDIĞI GRUP:D GRUBU
 ***************************************************************/
using System;
using System.Collections;

namespace _8rook
{
    class Program
    {
        static void Main(string[] asd)
        {
            // Değişkenleri tanımladım.
            Random rand = new Random();
            int first = 0;
            int sec = 0;
            int k = 0;
            ArrayList satir = new ArrayList();
            ArrayList sutun = new ArrayList();
            string[,] dizi = new string[8, 8];

            for (int a = 0; a < 8; a++) // Satranc dizisinin butun elemanlarını 0 a esitledim ve ekrana butun elemanları 0 olan bir matris yazdirdim.
            {
                for (int b = 0; b < 8; b++)
                {
                    dizi[a, b] = "0";
                }
            }

            while (k < 8) //
            {
                first = rand.Next(0, 8);
                sec = rand.Next(0, 8);

                if (!(satir.Contains(first) || sutun.Contains(sec)))
                {
                    k++;
                    satir.Add(first);
                    sutun.Add(sec);
                    dizi[first, sec] = "K";

                    for (int a = 0; a < 8; a++)
                    {
                        for (int b = 0; b < 8; b++)
                        {
                            Console.Write(dizi[a, b]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                }
            }
            Console.Read();
        }
    }
}
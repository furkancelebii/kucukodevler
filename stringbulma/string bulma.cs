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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arama
{
    public class Menu
    {
        private static string harf = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ";

        static void Main(string[] args)
        {
            Console.WriteLine("MENU");Console.WriteLine();
            Console.WriteLine("1 - String bir değişkende, string değeri substring kullanmadan ara...");
            Console.WriteLine("2 - String bir değişkende, string değeri substring kullanarak ara...");
            Console.WriteLine("3 - Alfabenin karakterlerini bir string de ara kaç defa geçiyor bul ve çiz..."); Console.WriteLine();
            Console.Write("Seçiminiz:");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim== 1)
            {
                Console.WriteLine();
                Console.Write("Aranılacak kelime :");
                string aranacak = Console.ReadLine();
                Console.Write("Karakter dizini :");
                string dizin = Console.ReadLine();
                int indis = dizin.IndexOf(aranacak);

                while (indis != -1)
                {
                    Console.WriteLine("Kelime "+ aranacak+" indisi :" + indis);
                    indis = dizin.IndexOf(aranacak, indis + 1);
                }
                Console.Read();

            }
            if (secim == 2)
            {
                Console.WriteLine();
                Console.Write("Aranılacak kelime :");
                string aranacak = Console.ReadLine();
                Console.Write("Karakter dizini :");
                string dizin = Console.ReadLine();

                for (int i = 0; i < dizin.Length; i++) //Dizinin genişliğini kullanarak kelimenin cümle içerisindeki indislerini buldum.
                {
                    if (dizin.Length - i >= aranacak.Length)
                    {
                        string kelime = dizin.Substring(i, aranacak.Length); //Substring ile kelimenin cümlede olup olmadığını kontrol ettim.
                        {
                            if (kelime == aranacak)
                                Console.WriteLine("Kelime " + aranacak + " indisi :" + i);
                        }
                    }
                }
                Console.Read();
            }
            if (secim == 3)
            {
                char[] stringChar, harfDizini;
                int[] harfler = new int[32];

                Console.Write("Karakter dizini giriniz :"); string cumle = Console.ReadLine().ToUpper();
                harfDizini = harf.ToCharArray();
                stringChar = cumle.ToCharArray();

                for (int i = 0; i < harfler.Length; i++) // Harfler dizinin değerlerini 0 a atadm.
                {
                    harfler[i] = 0;
                }

                for (int j = 0; j < harfDizini.Length; j++) //Cümledeki harfleri kontrol ettirdim eğer cümle içerisinde bulunduysa diziye değeri atandı.
                {
                    for (int k = 0; k < stringChar.Length; k++)
                    {
                        if (harfDizini[j] == stringChar[k])
                        {
                            harfler[j] = harfler[j] + 1;
                        }
                    }
                }

                Console.WriteLine("...........................................................................................");
                for (int n = 0; n < harfler.Length; n++) //Alfabedeki harfleri yazdım.
                {
                    Console.Write(harfDizini[n] + " sayısı: ");
                    Console.Write(harfler[n] + " ");
                    for (int m = 0; m < harfler[n]; m++) // Cümlede bulunan harf sayısı kadar "*" işareti kullandım.
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    
                }
                Console.Read();
            }

        }
    }
}

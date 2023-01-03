/****************************************************************************
**					   SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					  2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2-1
**				ÖĞRENCİ ADI............: MAZHAR FURKAN ÇELEBİ
**				ÖĞRENCİ NUMARASI.......: G191210033
**              DERSİN ALINDIĞI GRUP...: 2.ÖĞRETİM C GRUBU
****************************************************************************/
using System;
using System.Collections;

namespace Question1
{
    class Program
    {
        class BenimString
        {
            public string cumle;
            public int eSayisi()
            {

                int x = 0;
                // Girilen stringin icinde dolasılır, x degiskeni 1 artirilarak stringin uzunluguna ulasilir.
                foreach (var a in cumle)
                {
                    x++;
                }
                return x;
            }
            public void birlestir()
            {
                string cumle_2;
                Console.WriteLine("Lütfen birleştirmek istediğiniz metni giriniz");
                cumle_2 = Console.ReadLine();
                Console.WriteLine("Birleşilen metin : " + cumle + " " + cumle_2);
            }
            public void aGir(int k)
            {
                Console.Write("Araya girilecek metni giriniz: ");
                string ekMetin = Console.ReadLine();
                //Alınan parametreye kadar stringi yazar
                for (int i = 0; i < k; i++)
                {
                    Console.Write(cumle[i]);
                }
                Console.Write(ekMetin);
                //Alınan parametreden sonra stringin geri kalan kismini yazar.
                for (int j = k; j < this.eSayisi(); j++)
                {
                    Console.Write(cumle[j]);
                }
                Console.WriteLine();
            }
            public void dAl()
            {

                Console.Write("Kaçıncı indisten itibaren alacağınzı giriniz: ");
                int indis = int.Parse(Console.ReadLine());
                Console.Write("Kaç karakter döndürüleceğini giriniz: ");
                int karakter = int.Parse(Console.ReadLine());

                //Girilen indisten baslayarak girilen karakter kadar string degerini yazdirir.
                for (int i = indis - 1; i < karakter + indis - 1; i++)
                {
                    Console.Write(cumle[i]);
                }
                Console.WriteLine();
            }
            public void dAyir()
            {

                Console.Write("Hangi karaktere göre ayrılacağını seç: ");
                char ayrac = Convert.ToChar(Console.ReadLine());
                ArrayList array = new ArrayList();

                string bosluk = "";

                for (int i = 0; i < this.eSayisi(); i++)
                {
                    if (cumle[i] != ayrac)
                    {
                        bosluk += cumle[i];
                        if (i == (this.eSayisi() - 1))
                            array.Add(bosluk);
                        continue;
                    }
                    array.Add(bosluk);
                    bosluk = "";
                }
                foreach (string s in array)
                {
                    Console.WriteLine(s);
                }


            }
            public char[] chardonustur()
            {
                char[] harfler = new char[this.eSayisi()];
                for (int i = 0; i < this.eSayisi(); i++)
                    harfler[i] = cumle[i];
                return harfler;
            }
            public void dindis()
            {
                Console.Write("Aranilacak Kelime: ");
                string aranilacakKelime = Console.ReadLine();
                int i = -1;
                //Aranan kelimeyi buldugu sayida yazdırır.
                while (true)
                {

                    i = cumle.IndexOf(aranilacakKelime, i + 1);
                    //Aranılan kelime bulunamazsa döngüden çıkılır.
                    if (i == -1)
                    {
                        break;
                    }
                    Console.WriteLine("Indis: " + i);
                }
            }
            public void AZye()
            {
              
                char[] harf = this.chardonustur();
                Array.Sort(harf);   
                Console.Write("A'dan Z'ye sıralanışı: ");

                //Sıralanan elemanlari yazdirma
                for (int i = 0; i < this.eSayisi(); i++)
                {
                    Console.Write(harf[i] + " ");
                }
                Console.WriteLine();
            }
            public void ZAya()
            {
                char[] harf = this.chardonustur();
                Array.Sort(harf);
                Console.Write("Z'den A'ya sıralanışı: ");

                //Sıralanan elemanlari tersten yazdirma
                for (int i = this.eSayisi() - 1; i >= 0; i--)
                {
                    Console.Write(harf[i] + " ");
                }
                Console.WriteLine();
            }

            public void tCevir()
            {
                //Girilen metni sondan başa doğru çevirir. 
                Console.Write("Metnin tersi: ");
                for (int i = this.eSayisi() - 1; i >= 0; i--)
                {
                    Console.Write(cumle[i] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int secim;
            BenimString stringim = new BenimString();
            Console.WriteLine("Lütfen metni giriniz");
            stringim.cumle = Console.ReadLine();

            //Menuyu oluşturdum.
            do
            {
                Console.WriteLine(); 
                Console.WriteLine();
                Console.WriteLine("-----------ANA  MENU-----------");
                Console.WriteLine("1-Eleman sayisi  ");
                Console.WriteLine("2-Metin Birleştir ");
                Console.WriteLine("3-Araya Metin Ekleme");
                Console.WriteLine("4-Kaynak nesne değerini belirtilen indisten başlayarak belirtilen karakter kadar geri döndürme");
                Console.WriteLine("5-Kaynak nesne değerini verilen karaktere göre diziye ayırma ");
                Console.WriteLine("6-Kaynak nesne değerini char diziye dönüştürme ");
                Console.WriteLine("7-Kaynak nesne içerisinde aranan nesnenin indisini döndürme");
                Console.WriteLine("8-Kaynak nesnenin değerlerini a dan z ye sıralı döndürme");
                Console.WriteLine("9-Kaynak nesnenin değerini z den a ya sıralama ");
                Console.WriteLine("10-Kaynak nesnenin değerini ters çevirme");
                Console.Write("Seciminiz: ");

                secim = int.Parse(Console.ReadLine());

                //gelen değişkene göre işlem yaptırır.
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Eleman sayisi: " + stringim.eSayisi());
                        break;
                    case 2:
                        stringim.birlestir();
                        break;
                    case 3:
                        stringim.aGir(2);
                        break;
                    case 4:
                        stringim.dAl();
                        break;
                    case 5:
                        stringim.dAyir();
                        break;
                    case 6:
                        Console.WriteLine(stringim.chardonustur());
                        break;
                    case 7:
                        stringim.dindis();
                        break;
                    case 8:
                        stringim.AZye();
                        break;
                    case 9:
                        stringim.ZAya();
                        break;
                    case 10:
                        stringim.tCevir();
                        break;
                    default:
                        break;

                }

            } while (secim == 1 || secim == 2 || secim == 3 || secim == 4 || secim == 5 || secim == 6 || secim == 7 || secim == 8 || secim == 9 || secim == 10);

        }
    }
}
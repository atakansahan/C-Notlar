﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SayiBüyükveKüçük


            //int sayi1 = 0, sayi2 = 5;

            //if (sayi1>sayi2)
            //{
            //    Console.WriteLine("Sayi1 büyük");
            //}
            //else if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayi2 Büyük");
            //}
            //else
            //{
            //    Console.WriteLine("sayılar eşit");
            //}
            //Console.ReadKey();
            #endregion

            #region Çift ve Tek 
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girilen sayı Çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı Tektir.");
            //}
            //Console.ReadKey();
            #endregion

            #region Atama Arttırma
            //int a = 5;
            //int b = a++; // b=a; a++;
            //int b = ++a; // a++; b=a;

            //Console.WriteLine(a + " - " + b);
            //Console.ReadKey();
            #endregion

            #region Dörtİşlem
            //int sayi1, sayi2;

            //char islem;
            //String sonuc;

            //Console.Write("Birinci Sayi \t:");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci Sayi \t:");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İşlem Seçiniz \t:");
            //islem = Convert.ToChar(Console.ReadLine());

            //if (islem== '+')

            //{
            //    sonuc = (sayi1 + sayi2).ToString();
            //}
            //else if (islem == '-')

            //{
            //    sonuc = (sayi1 - sayi2).ToString();
            //}
            //else if (islem == '/')

            //{
            //    sonuc = (sayi1 / sayi2).ToString();
            //}
            //else if (islem == '*')

            //{
            //    sonuc = (sayi1 * sayi2).ToString();
            //}
            //else
            //{
            //    sonuc = "Hatalı İşlem";
            //}
            //Console.WriteLine("Sonuç \t\t:" + sonuc);
            //Console.ReadKey();

            #endregion

            #region Vize Final Harf Notu

            //int vize = Convert.ToInt32(Console.ReadLine());
            //int final = Convert.ToInt32(Console.ReadLine());

            //double sonuc = (vize * 0.4) + (final * 0.6);
            //Console.Write(sonuc + " ");
            //if (sonuc >= 85)
            //{
            //    Console.WriteLine("AA");
            //}
            //else if (sonuc >= 80 && sonuc <= 84)
            //{
            //    Console.WriteLine("BA");
            //}
            //else if (sonuc >= 75 && sonuc <= 79)
            //{
            //    Console.WriteLine("BB");
            //}
            //else if (sonuc >= 70 && sonuc <= 74)
            //{
            //    Console.WriteLine("CB");
            //}
            //else if (sonuc >= 60 && sonuc <= 69)
            //{
            //    Console.WriteLine("CC");
            //}
            //else
            //{
            //    Console.WriteLine("FF");
            //}

            //    Console.ReadLine();
            #endregion

            #region Vergi

            //Console.Write("Lütfen İsminizi Giriniz  : ");
            //string isim = Console.ReadLine().ToUpper();

            //Console.Write("Lütfen Maaşınızı Giriniz  : ");
            //int maas = Convert.ToInt32(Console.ReadLine());

            //if (maas <= 1300)
            //{
            //    Console.Write("Sayın, " + isim + ". Maaşınızdan vergi alınmamaktadır.");
            //}
            //if (maas > 1300 && maas <= 3000)
            //{
            //    Console.Write("Sayın, " + isim + ". Maaşınızdan " + (maas * 10 / 100) + " vergi alınmaktadır.");
            //}
            //if (maas > 3000)
            //{
            //    Console.Write("Sayın, " + isim + ". Maaşınızdan " + (maas * 20 / 100) + " vergi alınmaktadır.");
            //}

            //Console.ReadKey();
            #endregion

            #region Switch,Case Günler..

            //Bas:
            //Console.Write("1-7 arasında sayı giriniz:");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //switch (gun)

            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarsamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;
            //    default:


            //        goto Bas;
            //}
            //Console.ReadKey();
            #endregion

            #region Switch,Case Mevsimler
            //Bas:
            //Console.Write("1-12 arasında sayı giriniz:");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //switch (gun)

            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Kış");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("İlkbahar");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //    case 9:
            //        Console.WriteLine("Yaz");
            //        break;
            //    case 10:
            //    case 11:
            //    case 12:
            //        Console.WriteLine("Sonbahar");
            //        break;

            //    default:
            //        Console.WriteLine("Yanlış Girdiniz");
            //        break;

            //}
            //         if (gun <=0)
            //{
            //    goto Bas;
            //}

            //Console.ReadKey();
            #endregion

            #region 0,9 Sayıları yaz


            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            //Console.ReadKey();

            #endregion

            #region  Sayıların toplamı
            //int a = 0;
            //int toplam = 0;

            //while (a < 10)
            //{
            //    a++;
            //    toplam = toplam + a;
            //    Console.WriteLine(toplam);

            //}

            //Console.ReadKey();
            #endregion


            #region 10 tabanında bir sayı girilsin ikilik tabana çevir.
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int sonuc = 0;
            //int basamak = 1;
            //while (sayi > 0) 
            //{
            //    sonuc += (sayi % 2) * basamak;
            //    basamak *= 10;
            //    sayi /= 2;
            //}

            //Console.WriteLine(sonuc);
            //Console.ReadKey();

            #endregion

            #region Faktoriyel Hesaplama
            //int n = 10, fakto = 1, counter = 1;
            //while (counter <=n)
            //{
            //    fakto *= counter;
            //    counter++;
            //}
            //Console.WriteLine(fakto);
            //Console.ReadKey();
            #endregion

            #region TahminEt
            //Console.WriteLine("[1-10] bir sayı tuttum bul bakalım.");

            //Random r = new Random();
            //int rasgeleSayi = r.Next(1,11);

            //int tahmin, counter=0;

            //while (true)
            //{
            //    counter++;
            //    Console.Write("Tahminin Ne:");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == rasgeleSayi)
            //    {

            //        break;

            //    }

            //}
            //Console.WriteLine("\nTebrikler... {0}.adımda bildin", counter);
            //Console.ReadKey();
            #endregion

            #region Dörtİşlemler
            //bool devam = true;
            //while (devam)
            //{
            //    Console.Write("Birinci Sayi:");
            //    double sayi1 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("İkinci Sayi:");
            //    double sayi2 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("islem sec:");
            //    char islem = Convert.ToChar(Console.ReadLine());
            //    double sonuc;
            //    switch (islem)
            //    {
            //        case '+':
            //            sonuc = sayi1 + sayi2;
            //            break;
            //        case '-':
            //            sonuc = sayi1 - sayi2;
            //            break;
            //        case '*':
            //            sonuc = sayi1 * sayi2;
            //            break;
            //        case '/':
            //            sonuc = sayi1 / sayi2;
            //            break;
            //        default:
            //            Console.WriteLine("Böyle bir işlem yok ");
            //            sonuc = 0;
            //            break;
            //    }

            //    Console.WriteLine("Sonuc:" + sonuc);

            //    Console.WriteLine("devam mı? (evet) ");
            //    string cevap = Console.ReadLine();

            //    if (cevap =="evet")
            //    {
            //        devam = true;
            //    }
            //    else
            //    {
            //        devam = false;
            //    }
            //}
            //Console.WriteLine("Görüşürüz");
            //Console.ReadKey();
            #endregion

            #region TahminetVers.1.0.0.1
            //Console.WriteLine("[1-100] bir sayı tuttum bul bakalım.");

            //Random r = new Random();
            //int rasgeleSayi = r.Next(1, 101);

            //int tahmin, counter = 0;

            //while (true)
            //{
            //    counter++;
            //    Console.Write("Tahminin Ne: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == rasgeleSayi)
            //    {
            //        Console.WriteLine("Daha Büyük Tahmin Yap");
            //    }
            //    else if (tahmin > rasgeleSayi)
            //    {
            //        Console.WriteLine("Daha küçük tahmin yap");
            //    }
            //    else
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine("\nTebrikler... {0}.adımda bildin", counter);
            //Console.ReadKey();
            #endregion

            #region ToplamÇarpım
            
            //long toplam = 0, carpim = 1;

            //int n = Convert.ToInt32(Console.ReadLine());

            //string secim = Console.ReadLine();

            //int counter = 1;
            //while (counter <=n)
            //{
            //    if ( counter %2 ==1)
            //    {
            //        toplam += counter;
            //        carpim *= counter;
            //    }
            //    counter++;

            //}
            //if (secim == "topla")
            //{
            //    Console.WriteLine(toplam);
            //}
            //else if (secim == "carp")
            //{
            //    Console.WriteLine(carpim);
            //}
            //else
            //{
            //    Console.WriteLine(secim + "ne ??");
            //}
            //Console.ReadKey();
            
            #endregion
        }
    }
}
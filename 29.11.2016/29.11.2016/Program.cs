using System;
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



        }
    }
}
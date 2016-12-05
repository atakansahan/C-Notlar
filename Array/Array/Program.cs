using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Array 
            /*
            int[] array = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
            /*/
            #endregion

            #region SınıfSıralama
            /*
            Console.Write("Sınıf Mevudu ? :");
            int mevcut = Convert.ToInt32(Console.ReadLine());

            string[] ogrenciler = new string[mevcut];
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.Write(" {0}. öğrencinin ismi : ", i);
                ogrenciler[i] = Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("Öğrenciler: \n");
            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            /*/
            #endregion

            #region RasgeleSayı
            /*
            //-100 arası rasgele sayı oluştur -100 sayı üret Negatif/Pozitif 
            Random rnd = new Random();
            int pozitif = 0, negatif = 0, notr = 0;
            Console.Write("Kaç tane ?:\n");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[size];

            Console.Clear();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(-100, 101);
            }

            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
                if (sayi > 0)
                {
                    pozitif++;
                }
                else if (sayi < 0)
                {
                    negatif++;
                }
                else
                {
                    notr++;
                }
            }
            Console.WriteLine("{0} Pozitif sayı var. ", + pozitif);
            Console.WriteLine("{0} Negatif sayı var. ", + negatif);
            Console.WriteLine("{0} Tane notr   var. ", + notr);

            Console.ReadKey();
            /*/
            #endregion

            #region Günler
            /*
            int gundegeri;
            string[] gün = new string[7];
            gün[0] = "Pazartesi";
            gün[1] = "Salı";
            gün[2] = "Çarşamba";
            gün[3] = "Perşembe";
            gün[4] = "Cuma";
            gün[5] = "Cumartesi";
            gün[6] = "Pazar";
            Console.Write("Kaçıncı gündesiniz: ");
            gundegeri = int.Parse(Console.ReadLine());
            if ((gundegeri >= 1) && (gundegeri <= 7))
            {
                Console.WriteLine(gün[gundegeri - 1]);
            }
            else
            {
                Console.WriteLine("Yanlış İfade girdiniz");
            }

            Console.ReadKey();
            
    /*/
            #endregion
        }
    }
}

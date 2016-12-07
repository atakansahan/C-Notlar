using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.AddRange(new int[] { 2, 3, 4 });

            Console.WriteLine(numbers.Count);

            Console.Clear();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("{0} = {1}", i, numbers[i]);
            }
            Console.ReadKey();
            /*/

            /*
            int[] array = new int[2];
            array[0] = 3;
            array[1] = 5;

            List<int> list = new List<int>(array);

            Console.WriteLine("{0} Tane elaman yazdıracağım.", list.Count);

            foreach (var elm in list)
            {
                Console.Write(elm + " ");
            }
            Console.ReadKey();
            /*/
            /*
            List<int> numbers = new List<int>(new int[] { 1903, 1904, 1905, 1906, 1907 });
            int index = numbers.IndexOf(1907);
            /*/
            /*
            List<string> isimler = new List<string>();
            isimler.AddRange(new string[] { "Ali", "Veli", "Fatma", "Ayşe" });

            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            /*/

            //List<int> numbers = new List<int>();
            //numbers.Add(3);
            //numbers.Add(5);
            //numbers.AddRange(new int[] { 8, 10, 13, 3, 8 });

            // numbers.Remove(8);                   // Girilen değer silinir, 1den fazla ise ilk değer silinir.
            // numbers.RemoveAt(0);                 // Girilen index silinir.
            // numbers.RemoveRange(3, 2);           // Aralık siler.


            /* bool varmi = true;

            while (varmi)
            {
                if (numbers.Contains(8))
                {
                    numbers.Remove(8);
                }
                else
                {
                    varmi = false;
                }
            /*/

            // var result = numbers.Find(i => i > 5);               // 5'den büyük ilk değer döner

            // var result = numbers.FindAll(i => i > 5);            // 5'den büyük tüm elemanlar döner

            // var result = numbers.FindAll(i => i > 5).Count();    // 5'den büyük tüm elemanlar döner

            //numbers.Sort();
            //numbers.Reverse();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine("\n\t" + item);
            //}

            #region AlfabeSıralaTersten
            /*
            List<char> alfabe = new List<char>();

            for (char i ='a'; i <= 'z' ; i++)
            {
                alfabe.Add(i);
            }

            alfabe.Reverse();
            foreach (var item in alfabe)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
            /*/
            #endregion

            #region İsimler Sıralama
            List<string> isimler = new List<string>();

            isimler.Add("Hakan");
            isimler.AddRange(new string[] { "İrfan", "Atakan", "Aytekin", "Cemal", "Merve", "Yankı" });

            isimler.Sort();
            isimler.Reverse();

            foreach (var item in isimler)
            {
                Console.WriteLine("\t" + item);
            }
            Console.ReadKey();
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //Değişken Türü [] DiziAdi=new Değişken Türü[Eleman Sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Siyah";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "İstanbul";
            //cities[1] = "Paris";
            //cities[2] = "Nice";
            //cities[3] = "Atina";
            //cities[4] = "New York";

            //Console.WriteLine(cities[3]);

            //int[] numbers= new int[10];
            //numbers[0] = 50;
            //numbers[1] = 85;
            //numbers[2] = 858;
            //numbers[3] = 47;
            //numbers[6] = 65;
            //numbers[9] = 770;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Ankara", "Tahran", "Moskova", "Roma", "Madrid" };
            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elamanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Yeşil", "Beyaz", "Turuncu", "Gri", "Kahverengi" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 3, 28, 36, 420, 566, 613, 770, 889, 990, 1011, 1172, 8542 };
            //int count = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        count++;
            //        Console.WriteLine(numbers[i]);

            //    }
            //}
            //Console.WriteLine("-------------");
            //Console.WriteLine("3e tam bölünebilen sayısı: ");
            //Console.WriteLine(count);

            //char[] chars = { 'a', 'b', 'c', '*', '-', '.', '/' };

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            //int[] myArray = { 19, 82, 123, 884, 7755, 7856, 45257, 77778, 66659, 10110, 14411 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            //Console.WriteLine(myArray.Length.ToString());

            ////int[] numbers = { 78, 12, 85, 95, 22, 65, 88 };
            ////Array.Sort(numbers);
            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    Console.WriteLine(numbers[i]);
            ////}

            ////int[] numbers = { 78, 12, 85, 95, 22, 65, 88 };
            ////Array.Reverse(numbers);
            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    Console.WriteLine(numbers[i]);
            ////}

            #endregion

            #region Dizi Metotları

            string[] customers = { "Medine", "Murat", "Zeynep", "Şeyma", "Bedia", "Ramazan" };
            int index = Array.IndexOf(customers, "Zeynep");
            Console.WriteLine(index);

            int[] number = { 9, 18, 66, 70, 54, 87, 36, 98 };
            Console.WriteLine("Dizinin En Büyük Elemanı: " + number.Max() + " Dizinin En Küçük Elemanı: " + number.Min());

            #endregion

            Console.Read();
        }
    }
}
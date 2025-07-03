using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1,2,3,4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:in
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "istanbul", "kayseri", "muğla", "van", "artvin" };

            //foreach (string s in cities)
            //{
            //    Console.WriteLine(s);
            //}

            //int[] numbers = { 12, 54, 85, 78, 885, 715, 7889, 7458, 10155, 54889 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 12, 54, 85, 78, 885, 715, 7889, 7458, 10156, 54889 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 12, 54, 85, 78, 885, 715, 7889, 7458, 10155, 54889 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,8,9,15,98,125
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** CSharp Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Kullanıcıdan sınıftaki öğrenci sayısını alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}.sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz.
                }
                Console.WriteLine();
                studentExamAverage[i] = totalExamResult / 3;
            }

            //Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAverage[i]}");

                //Öğrencinin  geçip kalma durumu

                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("------------------------------");
            }

            #endregion

            Console.Read();
        }
    }
}
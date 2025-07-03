using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Geri Değer Döndürmeyen Parametresiz Metotlar

            //Geriye Değer Döndürmeyen Metotlar
            //Customer---> Listele,ekle,sil,güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Sinan Kaya");
            //    Console.WriteLine("Merve Kaya");
            //    Console.WriteLine("Elif Kaya");
            //    Console.WriteLine("Hakan Kaya");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geri Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Ayşe Güler");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Mehmet","Kaya");
            //CustomerCard("Tuğçe","Akın");

            #endregion

            #region Geri Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int numnber2, int number3)
            //{
            //    int result = number1 + numnber2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(15,12,10);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Sevilay Akın";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Büşra";
            //    string surName = "Akman";

            //    return name+" "+surName;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " " + "Başkent: " + capital + " " + "Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result=number1+number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(14,85));
            //Console.WriteLine(Sum(81,74));
            //Console.WriteLine(Sum(144,850));
            //Console.WriteLine(Sum(107,410)); 

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti -" + " Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavdan kaldı -" + " Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali", 50, 100, 75));
            Console.WriteLine(ExamResult("Veli", 30, 20, 10));

            #endregion

            Console.Read();
        }
    }
}

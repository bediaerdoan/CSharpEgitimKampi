using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            Console.Write("Merhaba Dünya!");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Soğuk Başlangıçlar");
            //Console.WriteLine("3-Ana Yemekler");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            
            #endregion

            #region String Değişkenler

            //string name = "Sinan";
            //Console.Write(name);
            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone;
            //string customerDistrict, customerCity, customerCountry;

            //customerName = "Sinan";
            //customerSurname = "Kaya";
            //customerEmail = "deneme@gmail.com";
            //customerPhone = "550 660 60 40";
            //customerDistrict = "Eyüpsultan";
            //customerCity = "İstanbul";
            //customerCountry = "Türkiye";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Müşteri: "+customerName+" "+customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: "+customerDistrict+"/"+customerCity+"/"+customerCountry);
            //Console.WriteLine("-------------------------------------------");

            //Console.WriteLine();

            //customerName = "Seda";
            //customerSurname = "Kılınç";
            //customerEmail = "test@gmail.com";
            //customerPhone = "550 440 60 60";
            //customerDistrict = "Kırkağaç";
            //customerCity = "Manisa";
            //customerCountry = "Türkiye";

            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity + "/" + customerCountry);
            //Console.WriteLine("-------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int number = 60;
            //Console.WriteLine(number);

            int hamburgerPrice = 350;
            int cokePrice = 90;
            int waterPrice = 20;
            int friesPrice = 90;
            int pizzaPrice = 350;
            int lemonadePrice = 60;

            Console.WriteLine("***** Restoran Menü Fiyatları *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatları *****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            hamburgerCount = 2;
            cokeCount = 3;
            waterCount = 6;
            friesCount = 6;
            pizzaCount = 4;
            lemonadeCount = 3;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;


            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalPizzaPrice + totalFriesPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Tutar:" + totalPrice + " TL");

            #endregion

            Console.Read();
        }
    }
}
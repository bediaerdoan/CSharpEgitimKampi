using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number = 78.27;
            //Console.WriteLine(number);
            //Console.WriteLine();

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, strawberryPrice, orangePrice, potatoPrice, tomatoPrice;
            //applePrice = 40.50;
            //strawberryPrice = 120;
            //orangePrice = 88.5;
            //potatoPrice = 69.99;
            //tomatoPrice = 33.99;

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice + "₺");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + "₺");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + "₺");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + "₺");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + "₺");

            //double appleGram, strawberryGram, orangeGram, potatoGram, tomatoGram;

            //appleGram = 3;
            //strawberryGram = 0.5;
            //orangeGram = 2.5;
            //potatoGram = 4.85;
            //tomatoGram = 3.159;

            //double appleTotalPrice = appleGram * applePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Alınan Ürün: Elma - " + " Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice.ToString("N2") + " ₺");
            //Console.WriteLine("Alınan Ürün: Çilek - " + " Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice.ToString("N2") + " ₺");
            //Console.WriteLine("Alınan Ürün: Portakal - " + " Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice.ToString("N2") + " ₺");
            //Console.WriteLine("Alınan Ürün: Patates - " + " Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice.ToString("N2") + " ₺");
            //Console.WriteLine("Alınan Ürün: Elma - " + " Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice.ToString("N2") + " ₺");

            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //double shoppingTotalPrice = appleTotalPrice + strawberryTotalPrice + orangeTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Ödenecek Toplam Tutar: " + shoppingTotalPrice.ToString("N2") + " ₺");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 's';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri/String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");

            //Console.WriteLine("Yolcu TC Kimlik No: " + passangerIdentityNumber + " - Yolcu Ad Soyad: " + passangerName + " " + passangerSurname + " Yolcu Adres Bilgisi: " + passangerDistrict + "/" + passangerCity + " Yolcu Yaş Bilgisi: " + passangerAge);

            //Console.WriteLine("------------------------------------");

            #endregion

            #region Klavyeden Tam Sayi Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 4895;
            //computerPrice = 28799;
            //chairPrice = 12849;
            //tvPrice = 129000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sıvav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sıvav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sıvav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + +exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}

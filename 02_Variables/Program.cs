﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: "+ applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: "+ orangePrice+ " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: "+ strawberryPrice+ " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: "+ potatoPrice+" TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: "+ tomatoPrice+ "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double applegram , orangegram, strawberrygram, potatogram, tomatogram;

            //applegram = 1.245;
            //orangegram = 2.650;
            //strawberrygram = 0.750;
            //potatogram = 4.859;
            //tomatogram = 3.745;

            //double appletotalprice = applegram * applePrice;
            //double orangetotalprice = orangegram * orangePrice;
            //double strawtotalprice = strawberrygram * strawberryPrice;
            //double potatotalprice = potatogram *potatoPrice;
            //double tomatotalprice = tomatogram * tomatoPrice;


            //Console.WriteLine("Alınan ürün: Elma -- " + "Birim Fiyat: " + applePrice + " TL" + " -- Gramaj: " + applegram + " gr" + "-- Toplam Tutar: " + appletotalprice + " TL");
            //Console.WriteLine("Alınan ürün: Portakal -- " + "Birim Fiyat: " + orangePrice + " TL" + " -- Gramaj: " + orangegram + " gr" + "-- Toplam Tutar: " + orangetotalprice + " TL");
            //Console.WriteLine("Alınan ürün: Çilek -- " + "Birim Fiyat: " + strawberryPrice + " TL" + " -- Gramaj: " + strawberrygram + " gr" + "-- Toplam Tutar: " + strawtotalprice + " TL");
            //Console.WriteLine("Alınan ürün: Patates -- " + "Birim Fiyat: " + potatoPrice + " TL" + " -- Gramaj: " + potatogram + " gr" + "-- Toplam Tutar: " + potatotalprice + " TL");
            //Console.WriteLine("Alınan ürün: Domates -- " + "Birim Fiyat: " + tomatoPrice + " TL" + " -- Gramaj: " + tomatogram + " gr" + "-- Toplam Tutar: " + tomatotalprice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double totalPrice= appletotalprice+ orangetotalprice+ strawtotalprice+ potatotalprice+tomatotalprice;

            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");



            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);





            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcunun Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();


            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No:  " + passengerIdentityNumber + " " + "Yolcu Ad Soyad: " + passengerName + " " +
            //    passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int. Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int. Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int. Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int. Parse(Console.ReadLine());

            //int totalPrice= shoesCount*shoesPrice+ computerCount*computerPrice + chairCount*chairPrice +tvCount*tvPrice ;

            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+ totalPrice+ " TL");




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result =( exam1+exam2+ exam3)/3;

            //Console.WriteLine();

            //Console.WriteLine("Ders Ortalama Notunuz: "+result);



            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender= char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+ gender);





            #endregion


            Console.ReadLine(); 

        }
    }
}

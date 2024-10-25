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
            #region Void Metotlar
            // Geriye Değer Döndürmeyen Metotlar
            // Customer--- Listele,ekle,sil, güncelle
            // Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Funda Ataca");
            //    Console.WriteLine("Gökhan Ataca");
            //    Console.WriteLine("Karan Ataca");
            //    Console.WriteLine("Pastel Ataca");

            //}

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

            #region Geriye Değer Döndürmeyen string Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);


            //}
            //WriteMethod("Funda Ataca");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+name +" "+ surName);

            //}

            //CustomerCard("Funda", "Ataca");
            //CustomerCard("Gökhan", "Ataca");








            #endregion

            #region Geriye Değer Döndürmeyen int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);



            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Funda Ataca";

            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Funda";
            //    string surname = "Ataca";

            //    return name +" " + surname;


            //}
            //Console.WriteLine(StudentCard());





            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string CountryName, string capital, string flagcolor)
            //{
            //    string cardInfo = "Ülke: " + CountryName + " -Başkent: " + capital + " -Bayrak Rengi: " + flagcolor;

            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("İtalya", "Roma","kırmızı-yeşil"));




            #endregion

            #region Geriye Değer Döndüren İnt Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 33));
            //Console.WriteLine(Sum(21,45 ));
            //Console.WriteLine(Sum(45,98));


            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1,int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti." + " Ortalama: "+ result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavda başarısız oldu." + " Ortalama: "+ result;
            //    }
            //}
            //Console.WriteLine(ExamResult( "Funda",45,76,98));
            //Console.WriteLine(ExamResult( "Gökhan",23,45,57));


            #endregion


            Console.Read();



        }
    }
}

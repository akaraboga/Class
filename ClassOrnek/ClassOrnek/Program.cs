using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Ogrenci1 = new Person();//Person clasındand new anahtar kelimesi ile Ogrenci1 nesnesi olusturduk.Bu sayede Person clasın da istediğimiz propertylere değer atayabileceğiz.
            Ogrenci1.Ad = "Ahmet";  //Ogrenci nesnesi ile Ad,Soyad,doğum tarihi propertylerine değerlierini atıyoruz.
            Ogrenci1.Soyad = "Karaboğa";
            Ogrenci1.Dtarih = 2001;

            Person Ogrenci2 = new Person();
            Ogrenci2.Ad = "Mehmet";
            Ogrenci2.Soyad = "Akif";
            Ogrenci2.Dtarih = 2000;

            Person Ogretmen1 = new Person();//Öğretmenler içinde aynı işlemi yapıyoruz.
            Ogretmen1.Ad = "Yiğit";
            Ogretmen1.Soyad = "Hacıefendioğlu";
            Ogretmen1.Dtarih = 1990;

            Person Ogretmen2 = new Person();
            Ogretmen2.Ad = "Nur";
            Ogretmen2.Soyad = "Nurullah";
            Ogretmen2.Dtarih = 1992;

            Console.WriteLine("Ogrenciler:");
            Console.WriteLine("1.ogrenci : {0} {1} doğum tarihi {2}",Ogrenci1.Ad,Ogrenci1.Soyad,Ogrenci1.Dtarih);
            Console.WriteLine("2.ogrenci :{0} {1} doğum tarihi {2}",Ogrenci2.Ad,Ogrenci2.Soyad,Ogrenci2.Dtarih);

            Console.WriteLine("\n");

            Console.WriteLine("Ogretmenler:");
            Console.WriteLine("1.ogretmen : {0} {1} doğum tarihi {2}",Ogretmen1.Ad,Ogretmen1.Soyad,Ogretmen1.Dtarih);
            Console.WriteLine("1.ogretmen : {0} {1} doğum tarihi {2}", Ogretmen2.Ad, Ogretmen2.Soyad, Ogretmen2.Dtarih);

            Console.Read();

        }

       


    }
}

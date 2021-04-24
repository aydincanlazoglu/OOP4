using System;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Ad = "Çamaşır Suyu";
            urun1.fiyat = 15.5 ;
            urun1.Id = 1 ;
            urun1.acıklama = "15 kg çamaşır suyu %100 kalite";

            Urun urun2 = new Urun();
            urun2.Ad = "Deterjan";
            urun2.fiyat = 10.88;
            urun2.acıklama = "Limon Deterjan";

            Urun urun3 = new Urun();
            urun3.Ad = "Şampuan";
            urun3.fiyat = 21;
            urun3.acıklama = "DALİN BEBEK ŞAMPUANI";


            string[] urun = new string[] {};
            Urun[] urunler = new Urun[] { urun1, urun2, urun3};

            foreach (var Urun in urunler)
            {
                Console.WriteLine(Urun.Ad);
                Console.WriteLine(Urun.fiyat);
                Console.WriteLine(Urun.acıklama);
                Console.WriteLine("***************");
            }
            sepetmeneger sepetmeneger = new sepetmeneger();
            sepetmeneger.ekle(urun1);
            sepetmeneger.ekle(urun2);
            sepetmeneger.ekle(urun3);
            Console.ReadKey();
        }
    }
}

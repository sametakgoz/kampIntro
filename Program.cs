using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.İsim = "İlkay";
            musteri1.Yas = 22;
            musteri1.Boy = 178;
            musteri1.Kilo = 67.3;

            Musteri musteri2 = new Musteri();
            musteri2.İsim = "Melissa";
            musteri2.Yas = 21;
            musteri2.Boy = 169;
            musteri2.Kilo = 60;

            Musteri musteri3 = new Musteri();
            musteri3.İsim = "Özge";
            musteri3.Yas = 21;
            musteri3.Boy = 175;
            musteri3.Kilo = 54;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.İsim+"  /  "+"yaş  : "+musteri.Yas+","+"boy : "+musteri.Boy+","+"kilo : "+musteri.Kilo);
                Console.WriteLine("--------------------");


            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);


        }
    }
}

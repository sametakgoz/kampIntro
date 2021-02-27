using System;

namespace day2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {


            // ürün ekleniyor
            Product urun1 = new Product();
            urun1.kategori = "telefon";
            urun1.urunAdi = "Samsung GAlaxy M51";
            urun1.fiyati = 3599;
            urun1.goruntulenme = 12456;
            urun1.stokSayisi = 36;
            // ürün ekleniyor
            Product urun2 = new Product();
            urun2.kategori = "Bilgisayar";
            urun2.urunAdi = "Stellseries Rivar 3RGB kablolu mause";
            urun2.fiyati = 313.99;
            urun2.goruntulenme = 121;
            urun2.stokSayisi = 17;

            //ürün ekleniyor

            Product urun3 = new Product();
            urun3.kategori = "akıllı bileklik";
            urun3.urunAdi = "Xiaomi Mi BAnd 5";
            urun3.fiyati = 219.00;
            urun3.goruntulenme = 38;
            urun3.stokSayisi = 50;
            


            Product [] urunler = new Product [] { urun1, urun2, urun3 };
            //sistemi dinamikleştirmek için ürünleri tek bir array'de topluyoruz



            for (int i = 0; i < urunler.Length; i++)
            {
               
                
                Console.WriteLine(urunler[i].kategori+" :"+ "adı"+urunler[i].urunAdi+" ,"+ 
                    "fiyat: "+urunler[i].fiyati+" ,"+"görüntülenme:"+ urunler[i].goruntulenme+", " +"stok:"+ urunler[i].stokSayisi);


            }

            



            foreach (Product urun  in urunler) 
            {
                Console.WriteLine(urun.kategori + ":" +"ürün adı :"  + urun.urunAdi + " "+ "fiyat :"+ 
                    urun.fiyati + " "+ "görüntülenme :" + urun.goruntulenme + " "+"stokta :" + urun.stokSayisi );
            }

        }


    }

    class Product
    {
     public string kategori { get; set; }
     public string urunAdi { get; set; }
     public double fiyati { get; set; }
     public int goruntulenme { get; set; }
     public int stokSayisi { get; set; }





        
    }
    
  }

 


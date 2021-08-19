using System;

namespace YazilimKampi
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.Id = 1;
            musteri1.TcNo = "12345678910";
            musteri1.MusteriNo = "12345";
            CustomerManager a = new CustomerManager();
            a.Ekle(musteri1); 
            TuzelMusteri musteri2 = new TuzelMusteri();


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            
            

        }
    }
}

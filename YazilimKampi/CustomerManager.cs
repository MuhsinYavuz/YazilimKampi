using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimKampi
{
    class CustomerManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müsteri :" + musteri.Id); 
        }
    }
}

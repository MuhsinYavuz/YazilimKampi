using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {
        public void BirseyYap()
        {
            Console.WriteLine("Seçilen Kredi : tasit "); 
        }

        public void Hesapla()
        {
            Console.WriteLine("Tasıt Kredisi ödeme planı hesaplandı."); 
        }
    }
}

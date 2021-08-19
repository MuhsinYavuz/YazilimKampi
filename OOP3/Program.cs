using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IKrediManager ihtiyacKredi1 = new IhtiyacKrediManager();
            ihtiyacKredi1.Hesapla(); 
            IKrediManager tasitKredi = new TasitKrediManager();
            tasitKredi.Hesapla();
            IKrediManager konutKredi = new KonutKrediManager();
            konutKredi.Hesapla();
            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(tasitKredi);
            List<IKrediManager> krediler = new List<IKrediManager>() {
            ihtiyacKredi1 , tasitKredi
            };
            DatabaseLoggerService database = new DatabaseLoggerService();
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            basvuruManager.BasvuruYap(tasitKredi,database);



        }
    }
}

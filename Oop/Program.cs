using System;
using System.Collections.Generic;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager(); 
            IKrediManager tasitKrediManager = new TasitKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager, esnafKrediManager };
            List<ILoggerServices> loggers = new List<ILoggerServices>() { new DatabaseLoggerService(), new SmsLoggerService() };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler, loggers);


        }
    }
}

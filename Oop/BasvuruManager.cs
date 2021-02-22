using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerServices loggerService) 
        {
            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //Başvuran bilgilerini değerlendirme
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

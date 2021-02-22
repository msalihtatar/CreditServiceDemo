using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı.");
        }
    }
}

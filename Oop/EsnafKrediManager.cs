using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class EsnafKrediManager : IKrediManager
    {
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class DatabaseLoggerService : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}

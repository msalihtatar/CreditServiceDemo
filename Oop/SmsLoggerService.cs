using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class SmsLoggerService : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("SMS yollandı.");
        }
    }
}

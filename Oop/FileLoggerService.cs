using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class FileLoggerService : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}

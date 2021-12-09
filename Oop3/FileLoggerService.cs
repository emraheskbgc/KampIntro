using System;

namespace Oop3
{
    class FileLoggerService : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}

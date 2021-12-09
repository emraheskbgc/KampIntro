using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class SmsLoggerService : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Sms Yolandı");
        }
    }
}

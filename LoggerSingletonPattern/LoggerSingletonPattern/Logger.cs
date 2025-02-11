using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerSingletonPattern
{
    public class Logger
    {
        private static Logger? _instance = null;

        private Logger()
        {
            
        }

        public static Logger GetInstance()
        {
            _instance ??= new Logger();
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

using System;

namespace WebApp.services
{
    public class Log : ILog
    {
        public void info(string str)
        {
            Console.WriteLine(str);
        }
    }
}

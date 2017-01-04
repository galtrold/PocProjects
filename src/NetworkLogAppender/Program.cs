using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace NetworkLogAppender
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            string nullString = null;
            var command = string.Empty;
            while (command != "exit")
            {
                Console.WriteLine("Press enter to log a message");
                command = Console.ReadLine();

                try
                {
                    var strLength = nullString.Length;
                }
                catch (Exception e)
                {

                    _log.Debug(e);
                }

                
            }







        }
    }
}

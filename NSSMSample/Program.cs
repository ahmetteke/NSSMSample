using System;
using System.Threading;

namespace NSSMSample
{
    class Program
    {
 
        private static volatile bool _breakLoop = false;
         
        static void Main(string[] args)
        {

            //!< Uygulamanın Ctrl+C veya Ctrl+Break ile kapatılabilmesi için gereklidir.
            //!< https://docs.microsoft.com/en-us/dotnet/api/system.console.cancelkeypress?view=netcore-3.1
            Console.CancelKeyPress += (sender, eventArgs) =>
            {
                _breakLoop = true;
                eventArgs.Cancel = true;
            };

            Console.WriteLine("Service Started.");
             
            while (!_breakLoop)
            {

                Console.WriteLine("Service Working ..."); 
                Thread.Sleep(500);
            }
             
            Console.WriteLine("Service Stopped.");
          
        }

    }
}

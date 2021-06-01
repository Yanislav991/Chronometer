using System;
using System.Threading.Tasks;

namespace Chronometer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var chronometer = new Chronometer();
            var input = Console.ReadLine();
            if (input == "start")
            {
                chronometer.Start();
            }
            else if (input == "stop")
            {
                chronometer.Stop();
            }
            else if (input == "lap") 
            {
                Console.WriteLine(chronometer.Lap());
            }
            
        }
    }
}

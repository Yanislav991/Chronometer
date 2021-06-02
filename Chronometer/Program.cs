using System;
using System.Threading.Tasks;

namespace Chronometer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var chronometer = new Chronometer();
            while (true)
            {
                var input = await GetInputAsync();
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
                else if (input == "laps")
                {
                    foreach (var lap in chronometer.Laps)
                    {
                        Console.WriteLine(lap);
                    }
                }
                else if (input == "time")
                {
                    Console.WriteLine(chronometer.GetTime);
                }
                else if (input == "reset") 
                {
                    chronometer.Reset();
                }
                else if (input == "exit")
                {
                    Environment.Exit(0);
                }

            }


        }
        private static async Task<string> GetInputAsync()
        {
            return await Task.Run(() => Console.ReadLine());
        }
    }
}

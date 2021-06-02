using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Chronometer
{
    public class Chronometer : IChronometer
    {
        Stopwatch sw = new Stopwatch();
        public Chronometer()
        {
            this.Laps = new List<string>();
        }
        public string GetTime => sw.Elapsed.ToString("c");

        public List<string> Laps { get ; private set ; }


        public string Lap()
        {
            TimeSpan timeSpan = sw.Elapsed;
            var lap = timeSpan.ToString("c");
            this.Laps.Add(lap);
            return lap;
        }

        public void Reset()
        {
            sw.Stop();
            sw.Reset();
            
            this.Laps.Clear();
        }

        public void Start()
        {
            sw.Start();
        }

        public void Stop()
        {
            sw.Stop();
        }
    }
}

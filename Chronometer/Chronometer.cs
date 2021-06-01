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
            
        }
        public string GetTime => sw.Elapsed.ToString();

        public List<string> Laps => new List<string>();

        public string Lap()
        {
            TimeSpan TimeSpan = sw.Elapsed;
            var lap = string.Format("{0}:{1}:{2}", TimeSpan.TotalMinutes, TimeSpan.Seconds, TimeSpan.Milliseconds);
            this.Laps.Add(lap);
            return lap;
        }

        public void Reset()
        {
            sw.Reset();
            sw.Stop();
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

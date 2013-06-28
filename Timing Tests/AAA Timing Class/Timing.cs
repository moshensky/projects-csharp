using System;
using System.Diagnostics;

namespace AAA_Timing_Class
{
    public class Timer
    {
        private TimeSpan startingTime;
        private TimeSpan duration;

        public Timer()
        {
            this.startingTime = new TimeSpan(0);
            this.duration = new TimeSpan(0);
        }

        public void StopTime()
        {
            this.duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
        }

        public void startTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.startingTime = Process.GetCurrentProcess().Threads[0].
            UserProcessorTime;
        }

        public TimeSpan Result()
        {
            return this.duration;
        }
    }
}

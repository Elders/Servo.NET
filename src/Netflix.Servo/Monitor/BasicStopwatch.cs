﻿using System;

namespace Netflix.Servo.Monitor
{
    /**
 * This class does not enforce starting or stopping once and only once without a reset.
 */
    public class BasicStopwatch : Stopwatch
    {
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        public void start()
        {
            sw.Start();
        }

        public void stop()
        {
            sw.Stop();
        }

        public void reset()
        {
            sw.Reset();
        }

        public long getDuration(TimeSpan timeUnit)
        {
            return timeUnit.Ticks;
        }

        public long getDuration()
        {
            return sw.ElapsedTicks;
        }
    }
}
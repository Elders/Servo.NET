﻿namespace Netflix.Servo.Util
{
    /**
 * A wrapper around the system clock to allow custom implementations to be used in unit tests
 * where we want to fake or control the clock behavior.
 */
    public interface Clock
    {
        /**
         * A Clock instance that returns the current time in milliseconds since
         * the epoch using the system clock.
         */
        //Clock WALL() = System::currentTimeMillis;
        Clock WALL();

        /**
         * Returns the number of milliseconds since the epoch.
         */
        long now();
    }
}

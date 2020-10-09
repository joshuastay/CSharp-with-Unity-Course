using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 200;

            const int SecondsPerMinute = 60;

            // convert seconds to minutes

            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;

            int secondsLeftPlayed = totalSecondsPlayed % SecondsPerMinute;

            // print variables to console

            Console.WriteLine("Minutes: " + minutesPlayed);

            Console.WriteLine("Seconds: " + secondsLeftPlayed);
        }
    }
}

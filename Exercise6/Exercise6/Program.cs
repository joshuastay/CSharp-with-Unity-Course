using System;
using System.Threading;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreesAngle = 56;

            float cosine = (float)Math.Cos(degreesAngle * Math.PI / 180);

            float sine = (float)Math.Sin(degreesAngle * Math.PI / 180);

            Console.WriteLine("The cosine of 56 degrees is: " + cosine);

            Console.WriteLine("The sine of 56 degrees is: " + sine);

            Console.WriteLine();

        }
    }
}

using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First altitude: ");

            int firstAltitude = int.Parse(Console.ReadLine());

            Console.Write("Enter Second altitude: ");

            int secondAltitude = int.Parse(Console.ReadLine());

            int differenceAltitudes = firstAltitude - secondAltitude;

            if (differenceAltitudes < 0)
            {
                differenceAltitudes = differenceAltitudes * -1;

                Console.WriteLine("Change in Altitude is: " + differenceAltitudes);


            }
            else
            {
                Console.WriteLine("Change in Altitude is : " + differenceAltitudes);
            }
        }
    }
}

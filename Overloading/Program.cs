using System;
using System.Collections;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle a1 = new Angle(2, 16, 50);
            Angle a2 = new Angle(10, 10, 15);
            Angle a3 = new Angle(4, 17, 55);


            Angle a7 = new Angle(15, 27, 36);

            a3.Seconds = 120;

            Console.WriteLine(a3);


            Angle minus = a1 + a7;
            //Console.WriteLine(a2);
            //Console.WriteLine(a7);
            Console.WriteLine(minus);

            Console.WriteLine(a1-a3);
            Angle[] angles = new Angle[5];
            angles[0] = a1;
            angles[1] = a2;
            angles[2] = a3;
            angles[3] = a7;
            angles[4] = minus;


            //Angle.SortAngles(angles);

            //foreach (var i in a3)
            //{
            //    Console.WriteLine(i);
            //}

            //Angle a5 = a1 + a3;


            //a2.Seconds = 0;
            //Console.WriteLine(a2);

            //Console.WriteLine(a3[2]);
            //Console.WriteLine(a1 == a2);


            //Angle a9 = a1 * 3;

            //Console.WriteLine(a9);
        }

    }
}

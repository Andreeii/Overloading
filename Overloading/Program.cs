using System;
using System.Collections;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle a1 = new Angle(7, 25, 30);
            Angle a2 = new Angle(10, 10, 15);
            Angle a3 = new Angle(11, 27, 17);

            Angle a7 = new Angle(15, 27, 36);

            Angle minus = a1 + a7;
            //Console.WriteLine(a2);
            //Console.WriteLine(a7);
            Console.WriteLine(minus);
            
            Angle[] angles = new Angle[5];
            angles[0] = a1;
            angles[1] = a2;
            angles[2] = a3;
            angles[3] = a7;
            angles[4] = minus;

            //Angle.SortAngles(angles);

            //foreach (var i in angles[0])
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

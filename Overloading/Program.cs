using System;
using System.Collections;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle a1 = new Angle(4, 45, 40);
            Angle a2 = new Angle(1, 10, 21);
            Angle a3 = new Angle(14, 100, 100);


            Angle[] angles = new Angle[3];
            angles[0] = a1;
            angles[1] = a2;
            angles[2] = a3;

            Angle.SortAngles(angles);

            Console.WriteLine(a3);
      
            Angle a5 = a1 + a3;
            Console.WriteLine(a5.ToString());

        }
    }
}

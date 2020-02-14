using System;
using System.Collections;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle a1 = new Angle(0, 59, 58);
            Angle a2 = new Angle(0, 10, 21);
            Angle a3 = new Angle(0, 0, 7200);



            Angle[] angles = new Angle[3];
            angles[0] = a1;
            angles[1] = a2;
            angles[2] = a3;

            Angle.SortAngles(angles);
           
      
            Angle a5 = a1 + a2;

            Console.WriteLine(a5);

        }
    }
}

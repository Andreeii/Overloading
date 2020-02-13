using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Overloading
{
    class Angle 
    {
        int x = 60;
        private int degrees, minutes, seconds;
        
        public int Degrees 
        {
            get;
            set; 
        }
        public int Minutes 
        {
            get;
            set;
        }
        public int Seconds
        {
            get;
            set;

        }
       public Angle(int Degrees,int Minutes,int Seconds)
        {

            if (Minutes >= 60)
                throw new Exception("Minutes can't be more than 60 value");
            if (Seconds >= 60)
                throw new Exception("Seconds can't be more than 60 value");
            this.degrees = Degrees;
            this.minutes = Minutes;
            this.seconds = Seconds;
        }
        public Angle(Angle angle)
        {
            degrees = angle.degrees;
            minutes = angle.minutes;
            seconds = angle.seconds;
        }


        public static bool operator ==(Angle l , Angle r )
        {
            if ((l.Degrees == r.Degrees)&&
                (l.Minutes == r.Minutes)&&
                (l.Seconds == r.Seconds))
            {
                return true;
            }
            else
                return false;

        }
        public static bool operator !=(Angle l, Angle r)
        {
            return !(l == r);
        }
      
        public static Angle operator +(Angle l, Angle r)
        {
            Angle result = new Angle(l);
            result.degrees = l.degrees + r.degrees;
            if (l.minutes + r.minutes >= 60)
            {
                result.minutes = l.minutes + r.minutes - 60;
                result.degrees++;
            }
            else
                result.minutes = l.minutes + r.minutes;

            if (l.seconds + r.seconds >= 60)
            {
                result.seconds = l.seconds + r.seconds - 60;
                result.minutes++;
            }
            else
                result.seconds = l.seconds + r.seconds;


            return result;

        }

        public static void SortAngles(Angle [] angle)
        {
            Angle temp;
            for(int i = 1;i <angle.Length ;i++)
            {
                for(int j = 0;j <angle.Length-1 ;j++)
                { 
                if (angle[j].degrees > angle[j + 1].degrees)
                    {
                        temp = angle[j];
                        angle[j] = angle[j + 1];
                        angle[j + 1] = temp;
                    }
                    else if (angle[j].minutes > angle[j + 1].minutes && angle[j].degrees == angle[j+1].degrees)
                    {
                        temp = angle[j];
                        angle[j] = angle[j + 1];
                        angle[j + 1] = temp;
                    }
                    else if (angle[j].seconds > angle[j + 1].seconds && angle[j].minutes == angle[j + 1].minutes)
                    {
                        temp = angle[j];
                        angle[j] = angle[j + 1];
                        angle[j + 1] = temp;
                    }
                }
            }
        }

        public int this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return degrees;
                    case 1:
                        return minutes;
                    case 2:
                        return seconds;
                    default:
                        throw new IndexOutOfRangeException(
                            "Attempt to retrieve Angle element " + i);
                }
            }
            set
            {
                switch (i)
                {
                    case 0:
                        degrees = value;
                        break;
                    case 1:
                        minutes = value;
                        break;
                    case 2:
                        seconds = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException(
                            "Attempt to set Angle element " + i);
                }
            }
        }

        public override string ToString()
        {
            return "Degrees: " + this.degrees + "   Minutes: " + this.minutes + "   Seconds: " + this.seconds;
        }
    }
}

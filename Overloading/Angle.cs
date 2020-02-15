using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Overloading
{
    class Angle 
    {
        private int degrees;
        private int minutes;
        private int seconds;
        
        public int Degrees 
        {
            get { return degrees; }
            set { this.degrees = Degrees + Minutes / 60; }
        }
        public int Minutes 
        {
            get { return minutes; }
            set { this.minutes = Minutes % 60 + Seconds / 60; }
        }
        public int Seconds
        {
            get { return seconds; }
            set 
            {
                seconds = value;
                seconds = seconds % 60;
            }

        }

        //works
       public Angle(int Degrees,int Minutes,int Seconds)
        {
            this.seconds = Seconds % 60;

            this.minutes = (Minutes  + (Seconds - seconds) / 60 ) % 60;

            this.degrees = Degrees + ((Minutes + (Seconds - seconds) / 60) - minutes) / 60;      
        }
        private Angle()
        {
            this.seconds = 0;
            this.minutes = 0;
            this.degrees = 0;
        }

        //overloaded ==
        public static bool operator == (Angle l , Angle r )
        {
            if ((l.degrees == r.degrees) &&
               (l.minutes == r.minutes) &&
               (l.seconds == r.seconds))
            {
                return true;
            }
            else
                return false;

        }

        //overloaded !=
        public static bool operator !=(Angle l, Angle r)
        {
            return !(l == r);
        }
      
        //overloaded +
        public static Angle operator + (Angle l, Angle r)
        {
            Angle result = new Angle();


            if (l.seconds + r.seconds >= 60)
            {
                result.seconds = l.seconds + r.seconds - 60;
                result.minutes++;
            }
            else
                result.seconds = l.seconds + r.seconds;

            if (l.minutes + r.minutes >= 60)
            {
                result.minutes += l.minutes + r.minutes - 60;
                result.degrees++;
            }
            else
                result.minutes += l.minutes + r.minutes;

            result.degrees += l.degrees + r.degrees;

            return result;

        }
        //sort works
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

        //works
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


        //works
        public static Angle operator *(Angle a , int i)
        {
            return  new Angle(a.Degrees * i,a.Minutes*i,a.Seconds*i);

        }


        //works 
        public static Angle operator -(Angle left , Angle r)
        {
            Angle rez = new Angle();

            Angle l = new Angle(left.Degrees,left.Minutes,left.Seconds);

            if (l.Seconds < r.Seconds)
            {
                l.minutes--;
                rez.seconds = l.Seconds + 60 - r.Seconds;
                
            }
            else
            {
                rez.seconds = l.Seconds - r.Seconds;
            }

            if (l.Minutes < r.Minutes)
            {
                l.degrees--;
                rez.minutes = l.Minutes + 60 - r.Minutes;
            }
            else
            {
                rez.minutes = l.Minutes - r.Minutes;
            }
            if (l.Degrees < r.Degrees)
            {
                rez.degrees = -(l.Degrees - r.Degrees);
            }
            else
            {
                rez.degrees = l.Degrees - r.Degrees;
            }

            return rez;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondenOmzettenNaarUrenMinutenEnEtc
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            int m = 0;
            int s = 0;
            SecToDaysHoursMins(61, out h, out m, out s);
            Console.WriteLine("{0} hours {1} minutes and {2} seconds", h, m, s);

           
        }

            public static void SecToDaysHoursMins(int totalSeconds, out int hours, out int mins, out int secs)
        {
         
            // tijdelijke tussentijdse variabele
            int rest = 0;

            // algoritme:
            hours = totalSeconds / (60 * 60);
            rest = totalSeconds % (60 * 60);
            mins = rest / 60;
            secs = rest % 60;

        }
    }
    struct HMSTTime
    {
        public int Hours;
        public int Mins;
        public int Secs;

        static HMSTTime ConvertSecondsToHMS(int totalSeconds)
        {
            
        }
    }
}
}


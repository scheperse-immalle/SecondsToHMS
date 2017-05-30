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
            HMSTime time = SecToHMS(61);
            Console.WriteLine("{0} hours {1} minutes and {2} seconds", time.Hours, time.Mins, time.Secs);

        }

        static HMSTime SecToHMS(int totalSeconds)
        {
            HMSTime time;
            int rest = 0;

            time.Hours = totalSeconds / (60 * 60);
            rest = totalSeconds % (60 * 60);
            time.Mins = rest / 60;
            time.Secs = rest % 60;
            return time;
        }

       
    }
    public struct HMSTime
    {
        public int Hours;
        public int Mins;
        public int Secs;

        
    }
}



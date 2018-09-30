using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_pamoka_ND
{
    class PointInTime
    {
       
        private int NowHH = DateTime.Now.Hour;
        private int NowMM = DateTime.Now.Minute;
        private int NowSS = DateTime.Now.Second;
        private DateTime Init;

        public PointInTime()
            {
            Init = DateTime.Now;
            }
        public DateTime CurrentTime ()
        {
            return DateTime.Now;
        }
        public DateTime InitTime()
        {
            return Init;
        }
        

    }
}

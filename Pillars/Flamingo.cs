using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Flamingo : Bird
    {
        private int leg;
        private int necksize;

        public int Leg
        {
            get { return leg; }
            set { leg = value; }
        }

       

        public int NeckSize
        {
            get { return necksize; }
            set { necksize = value; }
        }

    }
}

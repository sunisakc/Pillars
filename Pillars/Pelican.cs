using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Pelican : Bird
    {
        private int mouthopen;

        public int MouthOpen
        {
            get { return mouthopen; }
            set { mouthopen = value; }
        }
        private string mouthcolor;

        public string MouthColor
        {
            get { return mouthcolor; }
            set { mouthcolor = value; }
        }
    }
}

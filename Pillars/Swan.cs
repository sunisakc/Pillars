using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Swan : Bird
    {
        private string wingcolor;

        public string WingColor
        {
            get { return wingcolor; }
            set { wingcolor = value; }
        }

        private string nationality;

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Bird : Animal
    {
        private string color;
        private int wing;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        

        public int Wing
        {
            get { return wing; }
            set { wing = value; }
        }

    }
}

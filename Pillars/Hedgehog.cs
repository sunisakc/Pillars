using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Hedgehog : Animal
    {
        private int danger;
        private string mood;

        public int Danger
        {
            get { return danger; }
            set { danger = value; }
        }
        

        public string Mood
        {
            get { return mood; }
            set { mood = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    public class Horse : Animal
    {
        private string color;
        private int leg;
        

        public string  Color
        {
            get { return color; }
            set { color = value; }
        }
       

        public int Leg
        {
            get { return leg; }
            set { leg = value; }
        }

        //public Horse() { }
        //public Horse(string nam, float weg, int age, string color, int leg) :
        //    base(nam, weg, age)
        //{
        //    Color = color;
        //    Leg = leg;
        //}

        //public override string Start()
        //{

        //    return base.Start() + "Hourse color is:" + Color + "And have: " + Leg + ".";

        //}


    }
}

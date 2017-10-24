using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Person
    {


        // Creating Private Fields
        private
            int age;
            string fName;
            string lName;
            double height;
            float weight;



        // Creating Public properties for person class's objects

        // a public property for age

        public int Age // age attribute
        {

            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }

        // a public property for fName
        public string FirstName
        {

            set
            {
                fName = value;
            }
            get
            {
                return fName;
            }
        }

        // a public property for lName
        public string LastName
        {

            set
            {
                lName = value;
            }
            get
            {
                return lName;
            }
        }

        // a public property for height
        public double Height
        {

            set
            {
                height = value;
            }
            get
            {
                return height;
            }
        }

        // a public property for weight
        public float Weight
        {

            set
            {
                weight = value;
            }
            get
            {
                return weight;
            }
        }



    }
}

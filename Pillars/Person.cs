using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Person
    {
        // Private fileds 
        private int age;
        private string fname;
        private string lname;
        private float height;
        private float weight;


        // Q1 : Try to instantiate a new person in program file but can't directly access the variable from person class right now because it set as provate file.
        //Create Public Properties for private fields 

        // This is public property for age filed 
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }

        }    // This is public property for fName filed 

        public string firstName
        {
            set
            {
                fname = value;
            }
            get
            {
                return fname;
            }

        }


            public string lastName
        {
            set
            {
                lname = value;
            }
            get
            {
                return lname;
            }

        }

            public float Height
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
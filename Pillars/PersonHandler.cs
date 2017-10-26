using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class PersonHandler
    {
        //private List<Person> list = new List<Person>();

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;


        }


        public Person CreatePerson(int age, string fname, string lname, float height, float weight)
        {

            Person Allpeople = new Person();
            Allpeople.Age = age;
            Allpeople.firstName = fname;
            Allpeople.lastName = lname;
            Allpeople.Height = height;
            Allpeople.Weight = weight;

           return Allpeople;
            {
                //What should i return you ? 
                
            }

        } 
    }
}


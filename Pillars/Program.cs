using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Program
    {
        public static void Main(string[] args)
        {
            // QUESTION 1 --  NO YOU CAN'T DIRECTLY ACCESS THE VARIABLES(Private Fields of Person Class) 
            // BUT YOU CAN ACCESS THE PUPLIC PROPERTY OF THAT FIELD(VARIABLE)

            PersonHandler ShowThePersonalInfo = new PersonHandler();
            ShowThePersonalInfo.UserInfo();
       

        }

        

    }
}


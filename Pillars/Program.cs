using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Program
    {
        static void Main(string[] args)
        {


            Person Fullinfo = new Person();
            PersonHandler General = new PersonHandler();


            Console.Write("Tell me your First Name:  ");

            string yourFirstName = Console.ReadLine();

            Console.Write("Tell me your Last Name:  ");

            string yourLastName = Console.ReadLine();

            Console.Write("Tell me your age:  ");

            int yourAge = int.Parse(Console.ReadLine());


            Console.Write("Tell me your Height:  ");

            float yourHeight = int.Parse(Console.ReadLine());


            Console.Write("Tell me your Weight:  ");

            float yourWeight = int.Parse(Console.ReadLine());

            Person SaveInfo = new Person();
           SaveInfo =  General.CreatePerson(yourAge, yourFirstName, yourLastName, yourHeight, yourWeight);

           
            Console.WriteLine("Your Name is :" + SaveInfo.firstName);
            Console.WriteLine("Your Last name is :" + SaveInfo.lastName);
            Console.WriteLine("Your age is :" + SaveInfo.Age);
            Console.WriteLine("Your height is :" + SaveInfo.Height);
            Console.WriteLine("Your weight is :" + SaveInfo.Weight);





















            /*  //Person name = "Jane";
              //Person age = 25;
              var register = new Register();
              var addAnother = true;

              do
              {
                  addAnother = AddPerson(register, addAnother);
              } while (addAnother);
          }
          private static bool AddPerson(Register register, bool addAnother)
          {
              Console.WriteLine("Name:");
          }
          */
            //var register = new Register();
            //var addAnother = true;

            //do
            //{
            //    addAnother = addPersonal(addAnother, register);
            //} while (addAnother);


            //Console.WriteLine("######");
            //Console.WriteLine(register);

        }

        // private static bool addPersonal(Register register, bool addAnother)
        // {


        //     Console.Write("Enter your name: ");
        //     var personalinfo = Console.ReadLine();

        //     Console.Write("Enter your age: ");
        //     var myAge = Console.ReadLine();

        //     Console.Write("Enter your height: ");
        //     var myHeight = Console.ReadLine();

        //     Console.Write("Enter your weight: ");
        //     var myWeight = Console.ReadLine();
        // }
        // Person personinfo = new Person();
        // //person1.fName = "Sunisa";
        // PersonHandler personaldata = new PersonHandler();
        // // personinfo.firstName = "Sunisa";
        // // personaldata.SetAge(personinfo, 24);
        //// Console.WriteLine("First Name: " + personinfo.firstName + "Age:" + personinfo.Age);

    }

    }


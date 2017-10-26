using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    public class Animal
    {

        private string name;
        private float weight;
        private int age;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Animal()
        {

        }

        public Animal(string nam, float weg, int age)
        {
            Name = nam;
            Weight = weg;
            Age = age;
        }

        public virtual string Start()
        {
            return "Animal name: " + Name + "The weight is: " + weight + "Animal is: " + age + "years old.";
        }
    }
}
using System;
using System.Collections.Generic;

namespace PersonList
{
    class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            // how many years old
            get;
            set
            /*{
                if (value < 0)
                System.Console.WriteLine("Error: Age cannot be less than 0");
                else
                {
                    Age = value;
                }
            }*/;
        }

        public Person(string name)
        {
            if (name == "")
                System.Console.WriteLine("Error: No empty strings allowed for names");
            else
            {
                Name = name;
            }

        }

        public override string ToString()
        {
            return Name;

        }
        public override bool Equals(object? obj)
        {
            // Check for null and compare run - time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Person other = (Person)obj;    // cast object to person. Safe since checked above


            if (Name == other.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

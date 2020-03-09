using System;

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
        
    }
}

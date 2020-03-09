using System;
using System.Collections.Generic;

namespace PersonList
{
    class PersonEqualityComparer : IEqualityComparer<Person>
    {
        

        public bool Equals(Person person1, Person person2)
        {

            if (person1.Name == person2.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetHashCode(Person person)
        {
            var hCode = person.Name;
            return hCode.GetHashCode();
        }

    }
}

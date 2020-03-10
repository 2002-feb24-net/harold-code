using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfPersons = new List<Person>();
            int amountOfPersons = 5;
            for (int i = 0; i < amountOfPersons; i++)
            {
                System.Console.WriteLine("Enter name of person " + i + ":");
                string name = Console.ReadLine();
                listOfPersons.Add(new Person(name));
                // construct new person object with name parameter and add to list
            }
            System.Console.WriteLine("Showing list contents:");
            DisplayListContents(listOfPersons);

            System.Console.WriteLine("Checking for duplicates...");
            bool anyDuplicates = AreThereDuplicates(listOfPersons);

            if (anyDuplicates)
                System.Console.WriteLine("There are duplicates");
            else
                System.Console.WriteLine("No duplicates found");

            System.Console.WriteLine("Sorting with insertion sort...");
            InsertionSort3(listOfPersons);
            System.Console.WriteLine("Displaying sorted elements:");
            DisplayListContents(listOfPersons);
        }

        static void DisplayListContents(List<Person> listOfPersons)
        {
            foreach (var item in listOfPersons)
            {
                System.Console.WriteLine(item);
            }
        }

        static bool AreThereDuplicates(List<Person> listOfPersons)
        {
            var PersonEqC = new PersonEqualityComparer();
            var hashSet = new HashSet<Person>(listOfPersons, PersonEqC);

            if (listOfPersons.Count == hashSet.Count)
                return false; // no duplicates since hash set has no duplicate elements. Number of items must match
            else
                return true;
        }

        static void InsertionSort(List<Person> listOfPersons)
        {
            for (int i = 0; i < listOfPersons.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    int comparison = listOfPersons[j - 1].Name.CompareTo(listOfPersons[i].Name);
                    /* Less than zero 	This instance precedes strB.
                    Zero 	This instance has the same position in the sort order as strB.
                    Greater than zero 	This instance follows strB.

                    -or-

                    strB is null*/
                    /*if (comparison < 0)
                    // [i] < [j]
                    {
                        
                    }
                    else */
                    if (comparison > 0)
                    // [j -1] > [j]
                    {
                        string temp = listOfPersons[j - 1].Name;
                        listOfPersons[j - 1].Name = listOfPersons[j].Name;
                        listOfPersons[j].Name = temp;
                    }
                }
            }


        }
        static void InsertionSort2(List<Person> listOfPersons)
        {
            for (int i = 0; i < listOfPersons.Count; i++)
            {
                int j = i;

                while (j > 0)
                {
                    int comparison = listOfPersons[j - 1].Name.CompareTo(listOfPersons[i].Name);

                    /* Less than zero 	This instance precedes strB.
                    Zero 	This instance has the same position in the sort order as strB.
                    Greater than zero 	This instance follows strB.

                    -or-

                    strB is null*/
                    /*if (comparison < 0)
                    // [i] < [j]
                    {

                    }
                    else */
                    if (comparison > 0)
                    {
                        string temp = listOfPersons[j - 1].Name;
                        listOfPersons[j - 1].Name = listOfPersons[j].Name;
                        listOfPersons[j].Name = temp;
                    }
                    j--;
                }
            }
        }

        static void InsertionSort3(List<Person> listOfPersons)
        {
            for (int i = 1; i < listOfPersons.Count; i++)
            {
                Person personAtIndex = listOfPersons[i];

                for (int l = 0; l < i; l++)
                {


                    /* Less than zero 	This instance precedes strB.
                    Zero 	This instance has the same position in the sort order as strB.
                    Greater than zero 	This instance follows strB.

                    -or-

                    strB is null*/
                    /*if (comparison < 0)
                    // [i] < [j]
                    {

                    }
                    else */
                    if ((personAtIndex.Name.CompareTo(listOfPersons[l].Name)) < 0)
                    {
                        listOfPersons.Remove(personAtIndex);
                        listOfPersons.Insert(l, personAtIndex);
                        break;
                    }

                }
            }
        }

    }
}

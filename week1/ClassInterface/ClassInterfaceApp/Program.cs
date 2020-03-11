using System;

namespace ClassInterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            Console.WriteLine(myClass1.MyInt);

            MyClass myClass2 = new MyClass(12, "This is a new string");

            myClass2.PrintPrivateFields();

            Console.WriteLine(MyClass.myString3);

            string privateString = myClass2.InstanceMethod();
            Console.WriteLine(privateString);
        }
    }
}

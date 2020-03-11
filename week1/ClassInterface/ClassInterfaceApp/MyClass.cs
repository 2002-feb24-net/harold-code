using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInterfaceApp
{
    class MyClass
    {
        private string myString = "I am a private string";
        public int MyInt = 0;
        
        public string MyString { get; }

        private int myInt2 = 10;
        private string myString2 = "I am a private string";

        public static String myString3 = "I am a static string";

        public MyClass(int MyInt, String myString1)
        {
            this.MyInt = MyInt;

        }

        public MyClass()
        {

        }

        public void PrintPrivateFields()
        {
            Console.WriteLine($"Int {myInt2}, String = {myString2}");
        }

        public String InstanceMethod()
        {
            return myString2;
        }
    }
}

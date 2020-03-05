using System;

namespace DemoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            int candyBarAmount = GetStock("candy bar");
            Product candyBar = new Product();
            candyBar.SetValues("1", candyBarAmount, 5.0);
            System.Console.WriteLine(candyBar);
            int cerealAmount = GetStock("cereal");
            Product cereal = new Product();
            cereal.SetValues("21", cerealAmount, 4.5);
            System.Console.WriteLine(cereal);
        }
        static int GetStock(string name)
        {
            int quantity;
            do
            {
                System.Console.Write("Enter quantity of product " + name + ": ");
                return int.Parse(Console.ReadLine());
            }
            while (quantity < 0);   // 
            return quantity;
        }
    }
}
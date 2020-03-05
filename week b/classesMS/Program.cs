using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Harold", 1000);
            
            System.Console.WriteLine($"Account {account.Number} was created for {account.Owner}" +
            "\n" + $"with {account.Balance} initial balance.");

            account.MakeWithdrawal(500, System.DateTime.Now, "Rent payment");
            System.Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            System.Console.WriteLine(account.Balance);

            /*try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                System.Console.WriteLine("Exception caught creating account with negative balance");
                System.Console.WriteLine(e.ToString());
            }*/
            System.Console.WriteLine(account.GetAccountHistory());


        }
    }
}
using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Matthew",1500);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with balance of {account.Balance}");


            account.MakeWithDrawl(800, DateTime.Now, "buying gaming pc");
            Console.WriteLine($"account balance{account.Balance}");
        }
    }
}

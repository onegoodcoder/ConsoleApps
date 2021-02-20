using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Matthew",1500);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with balance of {account.Balance}");


            account.MakeWithDrawl(900, DateTime.Now, "buying gaming pc");
            //Console.WriteLine($"account balance{account.Balance}");


            account.MakeWithDrawl(200, DateTime.Now, "fornite skin");

           Console.WriteLine(account.GetAccountHistory());
        }
    }
}

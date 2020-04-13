using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine(account.GetBalance());
            account.Deposit(300);
            Console.WriteLine(account.GetBalance());
        }
    }
}

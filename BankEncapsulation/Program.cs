using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            Console.WriteLine(myAccount.GetBalance());
            myAccount.Deposit(300);
            Console.WriteLine(myAccount.GetBalance());
        }
    }
}

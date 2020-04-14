using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine(account.GetBalance());
            /*account.Deposit(300);
            Console.WriteLine(account.GetBalance());*/

            var ppi = new PersonalInformation(); //Class constructor
            //var names = new List<string>(); //List constructor

            string number;
            long result;

            do
            {
                Console.WriteLine("What is your area code and phone number?");
                number = Console.ReadLine();

            } while (number.Length != 10 || !long.TryParse(number, out result));

            ppi.NumberFormatted = number;
            Console.WriteLine($"{ppi.NumberFormatted }");
        }
    }
}

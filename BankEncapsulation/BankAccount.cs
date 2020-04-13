﻿using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit(double depositAmount)
        {
            balance += depositAmount;
        }

        public double GetBalance()
        {
            return balance;
        }

     }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Bank_account
    {
        private string clientName, accountNumber;
        private int balance;
        private bool block;

        public Bank_account(string clientName, string accountNumber)
        {
            this.clientName = clientName;
            this.accountNumber = accountNumber;
            this.balance = 0;
            this.block = false;
        }

        public int GetMoney(int amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                return balance;
            }
            else block = true;
            return 0;
        }
        public int GiveMoney(int amount)
        {
            balance += amount;
            return amount;
        }
        public void AccountBalance()
        {
            Console.WriteLine("Account Balance: {0}",balance);
        }

        public void unlockAccount()
        {
            block = false;
        }

        public override string ToString()
        {
            return $"Client: {clientName}\nAccount Number: {accountNumber} \nAccount Balance: {balance} \nAccount Status: {block}";
        }

    }
}

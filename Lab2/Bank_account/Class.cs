using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Bank_account
    {
        private BankClient bankClient;
        private string  accountNumber;
        private int balance;
        private bool block;

        public Bank_account(BankClient bankClient, string accountNumber)
        {
            this.bankClient = bankClient;
            this.accountNumber = accountNumber;
            this.balance = 0;
            this.block = false;
        }

        public int GetMoney(int amount)
        {
            if (block == false)
            {
                if (balance > amount)
                {
                    balance -= amount;
                    return balance;
                }
                else block = true;
                return 0;
            } return 0;
        }
        public int GiveMoney(int amount)
        {
            if (block == false)
            {
                balance += amount;
                return amount;
            } return 0;
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
            return $"Client: {bankClient}\nAccount Number: {accountNumber} \nAccount Balance: {balance} \nAccount Status: {block}";
        }

    }
}

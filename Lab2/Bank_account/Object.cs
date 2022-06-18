using System;
using System.Collections;
using Programowanie;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_account jakubAccount = new Bank_account("Jakub", "Numer konta");

            Console.WriteLine(jakubAccount);

            Console.WriteLine("----------");
            Console.WriteLine("");

            jakubAccount.GiveMoney(500);
            jakubAccount.GetMoney(200);
            jakubAccount.AccountBalance();
        }

    }
}   

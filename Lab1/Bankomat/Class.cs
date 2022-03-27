using System;
using System.Collections.Generic;
using System.Text;

//Napisz klasę Konto z polami nazwisko, numer, stan. 
//Dopisz metodę PobierzPieniądze, która zdejmuje pewną (pobraną jako argument) kwotę z konta (czyli zmniejsza wartość pola stan) oraz metodę WpłaćPieniądze, która wkłada pewną kwotę na konto. 
//Następnie dopisz metodę wypisującą stan konta.
//Dopisz konstruktor ustawiający zawartość pól nazwisko, numer (pole stan ma mieć wartość 0 na początku)
//Napisz program, który stwarza obiekt Konto i wywołuje na jego rzecz kilka razy metody PobierzPieniądze, WpłaćPieniądze. 

namespace ConsoleApp1
{
    class Konto

    {
        private string name, number;
        private double balance;

        public Konto(string name, string number)
        {
            this.name = name;
            this.number = number;
            this.balance = 0;
        }

        public void Get(int amount)
        {
            balance -= amount;
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public override string ToString()
        {
            return $"Imie: {name}, Numer: {number},\n Stan konta: {balance}";
        }


    }

}

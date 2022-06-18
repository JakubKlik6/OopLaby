using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class BankClient
    {
        private string name, surname;
        private int pesel;

        public BankClient(string name, string surname, int pesel)
        {
            this.name = name;
            this.surname = surname;
            this.pesel = pesel;
        }

        public override string ToString()
        {
            return $"Name: {name}\nSurname: {surname}\n\nPesel: {pesel}";
        }
    }
}

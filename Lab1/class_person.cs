using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Person
    {
        //przykładowe pola klasy
        //pola są najczęściej prywatne
        

        private string name;
        private int age;
        private double wealth;

        //teraz napiszemy konstruktor, czyli miejsce, gdzie nadajemy wartości początkowe polom klasy
        //konstruktor zawsze ma nazwę klasy 
        
        Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            wealth = 0;
        }
        //pykładowy konstrukor. Nadaje wartości początkowe trzem polom klasy
        //pole wealth ma na początku wartość 0
        //majać konstruktor możemy już tworzyć obiekty klasy Pperson
        //dopiszmy jeszcze metody (funkcje)

        public void getSalary()
        {
            wealth += 4000;
        }

        public void goShopping()
        {
            Random random = new Random();
            int howMuch = random.Next(100, 1000);           //losowa liczba z przedziału 100->1000

            if (wealth >= howMuch) 
            {
                wealth -= howMuch;
            }
        }


        public override string ToString()
        {
            return $"nazwisko: {name}, wiek: { age},bogactwo: {wealth}";
        }
        //użyłem template string - standardodwego zapisu pozwalającego włączyć stringa do wartości zmiennych czy pól
    }
}

using System;
using System.Collections.Generic;
using System.Text;

//Napisz klasę Uczen z polami nazwisko, ocena1, ocena2 oraz metodami Średnia, ToString (generująca napis zawierający nazwisko, obie oceny i średnią tych ocen).
// a) W klasie publicznej UczenTest stwórz ucznia, przypisz mu jakieś oceny i wypisz go.
// b) Zmień pola z ocenami na prywatne i dopisz metodę wstawOcenę, która będzie wstawiać oceny w pole ocena1 i nie pozwoli, żeby została wpisana liczba większa od 6 lub mniejsza od 1.

namespace ConsoleApp1
{
    class Student

    {
        private string surname;
        private int degree_1, degree_2;

        public Student(string surname, int degree_1, int degree_2)
        {
            this.surname = surname;
            this.degree_1 = degree_1;
            this.degree_2 = degree_2;
        }

        public double Mean()
        {
            return ((degree_1 + degree_2) / 2);
        }

        public override string ToString()
        {
            return $"Nazwisko: {surname}, ocenay: {degree_1} {degree_2}, średnia ocen: {Mean()}";
        }
    }

}

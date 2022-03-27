using System;
using System.Collections.Generic;
using System.Text;

//Napisz klasę Punkt z dwoma polami x, y oraz metodami: Wyzeruj, Przesuń, ToString.
//Następnie napisz program (czyli klasę publiczną np. PunktTest) i stwórz w nim obiekt klasy Punkt, przesuń go i sprawdź, czy zmieniły się jego współrzędne.

namespace ConsoleApp1
{
    class Point

    {
        private int x,y;
        private char name;


        public Point(int x,int y,char name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public void Reset()
        {
            y = 0;
            x = 0;
        }

        public void Move(int a,int b)
        {
            x += a;
            y += b;
        }


        public override string ToString()
        {
            return $"{name} = ({x},{y})";
        }
    }

}

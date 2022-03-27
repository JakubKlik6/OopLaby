using System;
using System.Collections.Generic;
using System.Text;

//Napisz klasę Pudełko z polami długość, szerokość, wysokość i metodami Objętość, ToString.
//W klasie publicznej PudełkoTest stwórz pudełko i oblicz jego objętość.

namespace ConsoleApp1
{
    class Box

    {
        private int lenght, width, heigh;

        public Box(int lenght,int width, int heigh)
        {
            this.lenght = lenght;
            this.width = width;
            this.heigh = heigh;
        }

        public int Volume()
        {
            int volume = lenght * width * heigh;
            return volume;
        }

        public override string ToString()
        {
            return $"Długość: {lenght}, szerokość: {width}, wysokość: {heigh}";
        }
    }

}

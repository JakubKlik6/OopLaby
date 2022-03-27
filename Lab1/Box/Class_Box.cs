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
        private double volume;


        public Box(int lenght,int width, int heigh)
        {
            this.lenght = lenght;
            this.width = width;
            this.heigh = heigh;
            this.volume = 0;
        }

        public void Volume()
        {
            volume = lenght * width * heigh;
        }

        public override string ToString()
        {
            return $"Długość: {lenght}, szerokość: {width}, wysokość: {heigh}";
        }
    }

}

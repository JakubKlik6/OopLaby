using System;
using System.Collections;
using Programowanie;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jum", "Buisness",2.8);
            Student student2 = new Student("Pam", "Art",3.8);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadKey(true);

        }
    }
}


//Class
using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Student
    {
        public string name, major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)       //contructor for Book class
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors()     //method
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encapsulation
{

    public class Person
    {
        private string name;
        private int age;
        private int birthYear;
        private double GPA;


        public Person(string name,int bYear, double GPA )
        {
            this.name = name;
            this.birthYear = bYear;
            this.GPA = GPA;
            this.age = 2566 - bYear;
        }

        public int getAge()
        {
            return this.age;
        }

        public string getName()
        {
            return this.name;
        }

        public double getGPA()
        {
            return this.GPA;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encapsulation
{
    internal class Classroom
    {
        double GPA = 0;
        double GradeMax = 0;
        double GradeMin = int.MaxValue;
        string NameMax = "";
        string NameMin ="";
        string name;
        private List<Person> persons = new List<Person>();

        public Classroom(string name)
        {
            this.name = name;
        }


        public void addPerson2Class(Person p)
        {
            this.persons.Add(p);
        }

        public string showAllPersoninClass()
        {
            string result = "";
            foreach (Person p in this.persons)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }

        public int showAgePersoninClass()
        {
            int SumAge = 0;
            foreach (Person p in this.persons)
            {
                SumAge += p.getAge();
            }
            return SumAge;
        }

        public double showavggradeinClass()
        {
            double SumGrade = 0;
            int n = 0;
            foreach (Person p in this.persons)
            {
                SumGrade += p.getGPA();
                n++;
            }
            return SumGrade/n;
        }

        public double GpaMax()
        {
            foreach (Person p in this.persons)
            {
                GPA = p.getGPA();
            }

                if(GPA > GradeMax)
                {
                    GradeMax = GPA;
                }
                if(GPA < GradeMin)
                {
                    GradeMin = GPA;
                }

            return GradeMax;
        }

        public double GpaMin()
        {
            foreach (Person p in this.persons)
            {
                GPA = p.getGPA();
            }

                if (GPA > GradeMax)
                {
                    GradeMax = GPA;
                }
                if (GPA < GradeMin)
                {
                    GradeMin = GPA;
                }

            return GradeMin;
        }

        public string showNameMaxinGPA()
        {
            foreach(Person p in this.persons)
            {
                name = p.getName();
                GPA = p.getGPA();
            }
                if (GPA > GradeMax)
            {
                GradeMax = GPA;
            }
                if (GPA < GradeMin)
            {
                GradeMin = GPA;
            }
                if (GPA == GradeMax)
            {
                this.NameMax = name;
            }
            return NameMax;
        }

        public string showNameMininGPA()
        {
            foreach(Person p in this.persons)
            {
                name = p.getName();
                GPA = p.getGPA();
            }
                if (GPA > GradeMax)
            {
                GradeMax = GPA;
            }
                if (GPA < GradeMin)
            {
                GradeMin = GPA;
            }
                if(GPA == GradeMin)
            {
                this.NameMin = name;
            }
            return NameMin;
        }

    }
}

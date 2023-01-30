using System;
using System.Diagnostics;

namespace LAB4Encapsulation
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_name = this.tbName.Text;
            string input_year = this.tbBirthYear.Text;
            string input_GPA = this.tbGPA.Text;


            //convert string to int double
            int iYear = Int32.Parse(input_year);
            double Gpa = Double.Parse(input_GPA);

            //create object from Person class
            Person person = new Person(input_name, iYear, Gpa);
            this.classroom.addPerson2Class(person);

            //display person
            this.tblistofPerson.Text = this.classroom.showAllPersoninClass();

            //display total Age of class
            this.tbTotal.Text = this.classroom.showAgePersoninClass().ToString();

            //display total SumAvg of class
            this.tbAvg.Text = this.classroom.showavggradeinClass().ToString("#.##");

            //display GradeMax
            this.tbMax.Text = this.classroom.GpaMax().ToString();

            //display GredeMin
            this.tbMin.Text = this.classroom.GpaMin().ToString();

            //display NameMax
            this.tbNameMax.Text = this.classroom.showNameMaxinGPA().ToString();

            //display NameMin
            this.tbNameMin.Text = this.classroom.showNameMininGPA().ToString();

            //Delete
            this.tbName.Text = "";
            this.tbBirthYear.Text = "";
            this.tbGPA.Text = "";

        }

        //Delete
        private void Delete_Click(object sender, EventArgs e)
        {
            this.tbName.Text = "";
            this.tbBirthYear.Text = "";
            this.tbGPA.Text = "";
        }

    }
}
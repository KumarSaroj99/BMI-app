using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BMI.Models
{
    internal class Person
    {
        //Default height and weight
        static double HT = 5;
        static int WEIGHT = 50;

        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Ht { get; set; } = HT;
        public int Weigth { get; set; } = WEIGHT;

        //Constructors
        public Person(int id, string name, int age)
        {
            Id = Id;
            Name = name;
            Age = age;
        }
        public Person(int id,string name,int age,double ht,int wegith):this(id,name,age)
        {
            Ht = ht;
            Weigth = wegith;
        }

        //To calculate BMI
        public double CalculateBMI()
        {
            Ht = Ht * 0.304;
            return Weigth  / (Ht * Ht);
        }

        //To determine body type
        public string BodyType(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMI.Models;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(100,"Raj",22,5.8,80);
            Person person2 = new Person(101, "Samu", 23, 5.9, 75);

            PrintPersonDetails(person1);
        }
        static void PrintPersonDetails(Person person)
        {
            string bodyType = person.BodyType(person.CalculateBMI());
            Console.WriteLine($"Name : {person.Name}\n" +
                $"Age : {person.Age}\n" +
                $"Height in Metre : {person.Ht}\n" +
                $"Weight in Kg : {person.Weigth}\n" +
                $"Your Body Type : {bodyType}");
        }
    }
}

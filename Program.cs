using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        /// <summary>
        /// Перечисление gender
        /// </summary>
        enum Gender 
        {
            Male,
            Female
        }

        /// <summary>
        /// Класс Person
        /// </summary>
        class Person 
        {
            public string FirstName { get; }
            public string LastName { get; }     
            public int Age { get; }
            public Gender Gender { get; }   
            public Person (string firstName, string secondName, int age, Gender gender) 
            {
                FirstName = firstName;
                LastName = secondName;
                Age = age;
                Gender = gender;
            }
        }
        /// <summary>
        /// Метод Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        }
    }
}

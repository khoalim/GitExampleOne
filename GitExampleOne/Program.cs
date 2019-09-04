using System;

namespace GitExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Kimberly";

            string lastName = "Ho-A-Lim";

            int age = 29;

            int puttingOnSomeYears = 40;

            int oldAge = age + puttingOnSomeYears;

            Console.WriteLine(firstName + " " + lastName); // Adding the " " gives a space btwn the names
     
            Console.WriteLine("I am " +  age + " years old");
            
            Console.WriteLine("I'm really glad I'm not " + oldAge + " years old");


        }
    }
}

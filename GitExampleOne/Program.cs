using System;

namespace GitExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Kimberly";

            string lastName = "Ho-A-Lim";

            string sweetness = "Not Brett";

            int age = 29;

            int puttingOnSomeYears = 40;

            int oldAge = age + puttingOnSomeYears;

            Console.WriteLine(firstName + " " + lastName); // Adding the " " gives a space btwn the names
     
            Console.WriteLine("I am " +  age + " years old"); // Put space btwn last or first letters and " to add space
            
            Console.WriteLine("I'm really glad I'm not " + oldAge + " years old");

            Console.WriteLine("Who is the sweetness? " + sweetness);


        }
    }
}

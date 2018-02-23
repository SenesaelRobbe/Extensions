using System;
using ExtensionLibrary;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail = "robbe.senesael@student.howest.be";
            string test2 = "a";
            Console.WriteLine($"{mail} is een emailadres: {mail.IsValidEmailAddress()}");
            Console.WriteLine($"{test2} is een mailadres: {test2.IsValidEmailAddress()}");

            string[] animals = { "monkey", "bear", "rabbit", "wolf" };
            if("bear".In(animals))
            {   
                Console.WriteLine("Animal found!");
            }
            else
            {
                Console.WriteLine("Animal not found??");
            }

        }
    }
}

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("Enter your name: ");
            person.Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            person.Age = int.Parse( Console.ReadLine() );

            Console.WriteLine();
            Console.WriteLine("Your name is {0} and your age is {1}", person.Name, person.Age); ;
        }
    }
}

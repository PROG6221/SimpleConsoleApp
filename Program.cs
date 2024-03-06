using System;

//namespace declaration 
namespace PROG6221
{
    //class declaration
    class Program
    {
        //main methods
        static void Main(string[] args)
        {
            //declaring variables 
            string name;
            string surname;
            int age;

            //outputs string to ask user for input 
            Console.WriteLine("Please enter your name: ");
            //reads user input and stores to variable 
            name = Console.ReadLine();

            Console.WriteLine("Please your surname: ");
            surname = Console.ReadLine();

            Console.WriteLine("Please your age: ");
            //converts string to int
            age = Convert.ToInt32(Console.ReadLine());
            //var ages = int.Parse(Console.ReadLine());

            //displaying inputs 
            Console.WriteLine("My name is " + name + " " + surname + " and I am " + age + " years old");


           

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, Color;
            int age;
            Console.WriteLine("What is your first name?); // there first name
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?"); // there last name
            lastName = Console.ReadLine();

            Console.WriteLine("What is your age"); // there age
            age = Convert.ToInt( Console.ReadLine());

            Console.WriteLine("What is your favorite color); // fav color
            Color = Console.ReadLine();
            

            // print out the confirmed the information message
            Console.WriteLine("Hello" + firstName + " " + lastName + " you are " + age + " years old. Your favorite color is " + color);
        }
    }
}

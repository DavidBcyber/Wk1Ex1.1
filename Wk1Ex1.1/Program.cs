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
            //Requires ask for first name, last name, age, color

            //declartion 
            string firstName = "";
            string lastName = "";
            int age = 0;
            string color = "";

            //print out the prompt to ask for first name input 
            Console.WriteLine("what is your first name?");
            //collect the user input for first name
            firstName = Console.ReadLine();
            //print out the prompt to ask for first name input 
            Console.WriteLine("what is your last name?");
            //collect the user input for first name
            lastName = Console.ReadLine();
            //print out the prompt to ask for first name input 
            Console.WriteLine("how old are you?");
            //collect the user input for first name
            age = Convert.ToInt32(Console.ReadLine());
            //print out the prompt to ask for first name input 
            Console.WriteLine("what is your fav color");
            //collect the user input for color
            color = Console.ReadLine();


            // print out the confirmed the information message
            Console.WriteLine("Hello" + firstName + " " + lastName + " you are " + age + " years old. Your fav color is " + color);


            Console.WriteLine($"Hello + {firstName}{lastName}. you are  + age +  years old. Your fav color is + { color}");
            //pause screen to read output
            Console.ReadLine();
        }
    }
}

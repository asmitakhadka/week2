using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.Write("Please enter your name: ")
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            
            Console.Write("Could you please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write($"Ok {name}, could you please enter your gender: ");           
            string gender = Console.ReadLine();
    
            Console.Write("Please enter your address: ");           
            string address = Console.ReadLine();

            Console.WriteLine("Ok, here is the information that i gathered:");
            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Address: {0}", address);


        }
    }
}

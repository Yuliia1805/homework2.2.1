using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber;
            int secondnumber;
            int thirdnumber;
            int fourthnumber;
            int fifthnumber;
            int sixthnumber;
            int seventhnumber;
            int eighthnumber;
            int ninthnumber;
            int tenthnumber;

            Console.Write("Enter your first number: ");
            firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is: " + firstnumber);
            Console.WriteLine("Your second number is: " + secondnumber);
            Console.WriteLine("Sum is: " + (firstnumber + secondnumber));

            Console.WriteLine("\n");

            Console.Write("Enter your first number: ");
            thirdnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            fourthnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is: " + thirdnumber);
            Console.WriteLine("Your second number is: " + fourthnumber);
            Console.WriteLine("Result is: " + (thirdnumber - fourthnumber));

            Console.WriteLine("\n");

            Console.Write("Enter your first number: ");
            fifthnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            sixthnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is: " + fifthnumber);
            Console.WriteLine("Your second number is: " + sixthnumber);
            Console.WriteLine("Result is: " + (fifthnumber * sixthnumber));

            Console.WriteLine("\n");

            Console.Write("Enter your first number: ");
            seventhnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            eighthnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is: " + seventhnumber);
            Console.WriteLine("Your second number is: " + eighthnumber);
            Console.WriteLine("Result is: " + (seventhnumber / eighthnumber));

            Console.WriteLine("\n");

            Console.Write("Enter your first number: ");
            ninthnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            tenthnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is: " + ninthnumber);
            Console.WriteLine("Your second number is: " + tenthnumber);
            Console.WriteLine("Result is: " + (ninthnumber % tenthnumber));






            Console.ReadLine();
        }
    }
}

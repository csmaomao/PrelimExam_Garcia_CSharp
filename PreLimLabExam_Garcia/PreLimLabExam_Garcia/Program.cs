using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4_Garcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|Choose a Program|");
            Console.WriteLine("[1] Leap Year");
            Console.WriteLine("[2] PHP to USD");
            Console.WriteLine("[3] Calculator");
            Console.Write("Choice: ");
            int whichProgram = Int32.Parse(Console.ReadLine());

            if (whichProgram == 1)
            {
                Console.WriteLine("\n------------------");
                Console.WriteLine("LEAP YEAR OR NOT?");
                Console.WriteLine("------------------");
                Console.Write("\nInput a Year: ");
                int year = Int32.Parse(Console.ReadLine());

                if (year % 400 == 0)
                {
                    Console.WriteLine("This is a Leap Year!");
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine("This is a not a Leap Year!");
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine("This is a Leap Year!");
                }
                else
                {
                    Console.WriteLine("This is not a Leap Year!");
                }
            }
            else if (whichProgram == 2)
            {
                Console.WriteLine("\n-----------------");
                Console.WriteLine("PESOS TO DOLLARS");
                Console.WriteLine("-----------------");
                Console.WriteLine("\nToday's Conversion Rate: 1 PHP = 0.018 USD");
                Console.Write("Input the amount of Philippine Peso: ");
                double pesos = Double.Parse(Console.ReadLine());
                //formula
                double dollars = 0.018;
                double converted = pesos * dollars;

                Console.WriteLine(pesos + " PHP in USD is " + converted);

            }
            else if (whichProgram == 3)
            {
                Console.WriteLine("\n-----------");
                Console.WriteLine("CALCULATOR");
                Console.WriteLine("-----------");

                Console.Write("\nInput First Number: ");
                Double first = Double.Parse(Console.ReadLine());
                Console.Write("Input Second Number: ");
                Double second = Double.Parse(Console.ReadLine());
                Console.WriteLine("Choose an Operator to use");
                Console.WriteLine("[A] Addition || [B] Subtraction || [C] Multiplication || [D] Division");
                Console.Write("Input the Letter: ");
                char operation = Char.Parse(Console.ReadLine());

                //formulas
                double addition = first + second;
                double subtraction = first - second;
                double multiplication = first * second;
                double division = first / second;

                switch (operation)
                {
                    case 'A':
                    case 'a':
                        Console.WriteLine("The answer for " + first + " + " + second + " is: " + addition);
                        break;
                    case 'B':
                    case 'b':
                        Console.WriteLine("The answer for " + first + " - " + second + " is: " + subtraction);
                        break;
                    case 'C':
                    case 'c':
                        Console.WriteLine("The answer for " + first + " * " + second + " is: " + multiplication);
                        break;
                    case 'D':
                    case 'd':
                        Console.WriteLine("The answer for " + first + "/" + second + " is: " + division);
                        break;
                    default: Console.WriteLine("Invalid Input! READ THE INSTRUCTION!"); break;

                }
            }
            else
            {
                Console.WriteLine("Invalid Input! ERROR! READ THE INSTRUCTION!");
            }

            Console.ReadKey();
        }
    }
}

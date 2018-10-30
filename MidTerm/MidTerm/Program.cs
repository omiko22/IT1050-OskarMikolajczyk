using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. 
            // The three types of control strucutres that we can use to order the statemnts in our programs are:
            // Sequential, Selection and Repetition.
            // Sequential is the default mode which the program will execute one line after the other. Depending on the logic
            // in our program we might want to perform actions in sequence, so this might be the right order.
            // Selection is used for making decisions in our program based on certain conditions. These are the if, if/else and switch 
            // statements.
            // Repetition is used for interating or looping over a piece of code a certain number of times or until a condition is met.
            // These are the while, do/while and for loops.

            //3.            
            //bool keepLooping = true;
            //while (keepLooping)
            //{
            //    keepLooping = true;
            //}

            //4.
            int i = 2;
            while (i <= 128)
            {
                Console.WriteLine($"[{i}]");
                i += i;
            }

            //5.
            for (int j = 49; j > 0; j--)
            {
                if (j != 1)
                {
                    Console.Write($"{j},");
                }
                else
                {
                    Console.Write($"{j}");
                }
            }

            //6.
            int number = 1;
            while (number <= 21)
            {
                if (number % 2 != 0)
                {
                    Console.Write($"{number} ");
                }
                number++;
            }

            //7. 
            // The output of the following code is a single '*' character in the console.
            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition

            // Output of the same code but using a while loop is an empty console window. This is because the do while loop
            // executed the code at least once before checking to see if the condition was still valid to continue further evaluation
            // The while loop checked the condition first and saw that 10 was larger than 8 not smaller, so it never executed the 
            // method body.
            while (i < n)
            {
                Console.Write("*");
                i++; // update!
            }

            //8.
            //You combine multiple boolean operators by using the && (and) operator or the || (or) operator
            //When you combine boolean operators you get the following output
            //for logical &&:
            // false && false == false;
            // false && true == false;
            // true && false == false;
            // true && true == true;
            //for logical ||
            // false || false == false;
            // false || true == true;
            // true || false == true;
            // true || true == true;
            // for inverted logical operator using !
            // !false == true;
            // !true == false;
            bool icyRain = false;
            bool tornadoWarning = false;
            if (!(icyRain && tornadoWarning))
            {
                Console.WriteLine("Let's go outside!");
            }

            // 9. 
            int counter = 5;
            while (counter > 0)
            {
                if(counter == 5)
                {
                    Console.WriteLine("123454321");
                    counter--;
                }
                if(counter == 4)
                {
                    Console.WriteLine("1234321".PadLeft(8, ' '));
                    counter--;
                }
                if(counter == 3)
                {
                    Console.WriteLine("12321".PadLeft(7, ' '));
                    counter--;
                }
                if(counter == 2)
                {
                    Console.WriteLine("121".PadLeft(6, ' '));
                    counter--;
                }
                if(counter == 1)
                {
                    Console.WriteLine("1".PadLeft(5, ' '));
                    counter--;
                }
                
            }

            Console.ReadKey();
        }
    }
}

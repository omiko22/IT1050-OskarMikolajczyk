using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.
            // The four necessary elements are variable, initial value, increment or decrement and the condition that enables the loop to continue executing.
            // The variable serves as the loop counter. The initial value is the starting point for the variable.
            // The increment and decrement is how the control variable is modified each time the loop executes, and the loop condition is what
            // determines if the loop should continue executing or if it should stop its executing and break out of the loop.

            // 3.
            // The 'while' repetition statement is different than the 'for' repetition statement because it will continue executing
            // indefinitely until a certain condition is met. The 'for' repetition statement has a pre-defined counter set determining 
            // how many times it the repetition statement will be executed.

            // 4.
            // Since do while repetition statements are evelauted after a specific action has been executed. It might be more approriate to implement a 
            // do while repetition statement when trying to perform a certain action that could succeed after the first attempt. For example
            // instructing the browser to locate an element in the HTML DOM, however if that element is not yet present we want to run the action again
            // The element that is being searched for could be found right away or it will require more time and attempts to be found.

            // The while repetition statement might be used when creating a console application where we want to continue to execute
            // our application logic until the user types in exit. This would allow us to ask the user if they want to continue usiting
            // our application by typing in c or exit by typing in e. After this we could check to see if the user's answer is c or e and either
            // continue or exit the application.

            //5.
            for (int j = 1; j < 100; j++)
            {
                if((j % 2) == 0)
                {
                    Console.WriteLine("It's even");
                }
                else
                {
                    Console.WriteLine("It's odd");
                }
            }

            //6.
            Console.Write("Please enter a temperature: ");

            int temp = Convert.ToInt32(Console.ReadLine());

            if(temp < 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if(temp < 20)
            {
                Console.WriteLine("Penguin");
            }
            else if(temp < 40)
            {
                Console.WriteLine("Moose");
            }
            else if(temp < 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (temp < 60)
            {
                Console.WriteLine("Deer");
            }
            else if(temp < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temp < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temp < 90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("Bug");
            }

            //7. 
            int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i);
                i++;
            }

            //8. 
            for (int k = 0; k < 101; k++)
            {
                Console.WriteLine(k);
                Console.WriteLine("********");
            }

            Console.ReadKey();
            
        }
    }
}

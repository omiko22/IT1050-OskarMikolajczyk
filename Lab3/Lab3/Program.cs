using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.
            // Compare and contrast the if single-selection statement and the while repetition statement
            // How are these two statements similar?  How are they different?
            //
            // The if single selection statement is a single check to see if a specific condition evaluates to true or false.
            // The if block of code will execute if the condition evaluated to true. This can be changed however if we reverse the 
            // condition with the ! exclamation point, in which case the if statement would check to see if a given condition
            // is not true.
            // The while repetition statement differs from the single if-selection statement because while the condition inside the
            // while repetition statement evaluates to true, the given block of code will continously keep executing. The while
            // repetition statement will first check to see if the given condition is true (or not true if reversed with !) and it is true
            // it will enter the given block of code and execute it. If the condition for the while loop has not changed to false
            // the loop will continue to execute until something inside the block causes the condition to evaluate to false.

            // 3.
            int speedLimit;
            speedLimit = 35;

            int speed;
            speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            // 4.

            bool isTrue = true;
            if (isTrue)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }

            // 5. 
            Console.Write("Enter temperature in Fahrenheit: ");

            double tempInC;

            double tempInF = Convert.ToDouble(Console.ReadLine());

            tempInC = (tempInF - 32d) * 5d / 9d;

            // I was not sure if you wanted to display the converted temp or entered temp
            Console.WriteLine($"The temperature you entered is: {tempInF}");

            Console.WriteLine($"The temperature converted to Celsius is: {tempInC}");

            if (tempInF < 40)
            {
                Console.WriteLine("It is cold");
            }
            else if (tempInF > 90)
            {
                Console.WriteLine("It is hot");
            }

            // 6.
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine(i);
                i += 1;
            }

            // 7.
            int j = 60;
            while (j >= 20)
            {
                Console.WriteLine(j);
                j -= 5;
            }

            // 8. 
            int k = 10;
            while (k < 21)
            {
                Console.WriteLine(k);
                k += 2;
            }

            Console.ReadKey();

        }
    }
}

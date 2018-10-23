using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        // a.At what point in the program does our C# Console Application execution?
        /* The program starts executing as soon as it enters in the static void Main method
         * 
         * b. What is the difference between an integer type variable and a double / floating-point variable?
         * int data type will store only integers and it doesnt allow for any precisions no decimal points
         * double data type will allow you to store a number with double precision decimal points
         * float data type will only allow you to store a number with a single precision decimal point
         * 
         * c.We can create blocks of code that we can call by name using a method.  Give an example of a method from Chapter 4.
         * An example of a method from Chapter four would be public string GetName(){ return name } This method would return the name 
         * attribute of the class
         * 
         * d.Like we have types double and int, we can create our own custom types using Classes.  
         * Each class has variables called instance variables or class members.  
         * To read the value of an instance variable, we create method called a GET accessor.  
         * To assign a value ton instance variable, we use a method called a SET accessor.
         * 
         * e.What is the difference between a class and an object?
         * Class defines the blue print, the template for what an object can be instantiated as.
         * Where as an object is an instance of that template/blueprint.
         * 
         * How many instances of a class can we create (please explain your answer)?
         * There is no limit as to how many instances of a class you can create. You are limited by the memory available to you by the machine
         * running your code. If you create a program that will continously instnatiate the same class over and over again and it will hold onto the
         * reference of that newly created object, you will create a memory leak, and the memory usage of the application will continue to grow
         * until the machine running the program will run out of memory, which will then cause the application to crash or it may cause the machine
         * running the application to crash.
         */


        static void Main(string[] args)
        {
            // 2. Using figure 3.18 (see below), create a program that allows input of two integers
            // Output the product (note: it must be multiplication).
            int number1;

            int number2;

            int sum;

            Console.Write("Enter first integer: ");

            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");

            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 * number2;

            Console.WriteLine($"Sum is {sum}");

            // 3.Add a single Console.WriteLine statement that outputs the following.  
            // Use Figure 3.17 (see below)
            // Hello World!
            // From[Your Name]

            Console.WriteLine("{0}\n{1}", "Hello World!", "From Oskar");

            // 4.Add an output statement that outputs the following
            // Note: there is a tab between the two phrases (3 points)
            // Hello World!From[Your Name]

            Console.WriteLine("{0}\t{1}", "Hello World!", "From Oskar");

        }        
    }
}

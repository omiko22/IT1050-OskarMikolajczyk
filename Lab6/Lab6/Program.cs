using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. 
            // Fill in the blanks in the following statement:
            // A one-dimensional array p contains four elements.
            // The array access expressions to access each of the elements in p are p[0], p[1], p[2] and p[3].

            //3. 
            string[] months = new string[12];

            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {months[i]}");
            }

            //4.
            string[] seasons = new string[] {"Spring", "Summer", "Fall", "Winter"};

            foreach (string season in seasons)
            {
                Console.WriteLine($"{season}");
            }

            // 5.Create an array of integers with 1000 elements.  
            // Fill the array with random numbers. randomNumber = random.Next(0, 100);  // place this line in the loop
            // Use a foreach loop to print all integers in the array.

            int[] numbers = new int[1000];
            Random random = new Random();

            // This part fills out the array of 1000 with random numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                // Here I use random.Next like instructed to populate the array with a random numbers
                numbers[i] = random.Next(0, 100);
            }

            // This part displays each number that is in the array
            foreach (int number in numbers)
            {
                Console.WriteLine($"{number}");
            }

            // 6. 
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int j = 0;
            while (j < names.Length)
            {
                Console.WriteLine(names[j]);
                j++;
            }

            // 7.
            string[] names2 = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int k = 0;
            while (k < names.Length)
            {
                // You could modify the the first argument k to k + 1 to display number 1 then 2 and so fourth
                // instead of the 0 index based number in the array. Like so:
                // Console.WriteLine("{0,2}. {1}", k + 1, names2[k]);
                Console.WriteLine("{0,2}. {1}", k, names2[k]);
                k++;
            }

            //8. 
            string[] names3 = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int counter = 0;
            foreach (string name in names3)
            {
                //Console.WriteLine("{0,2}. {1}", counter + 1 , name);
                Console.WriteLine("{0,2}. {1}", counter, name);

                counter++;
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A3
{
    class Program
    {
        static void Main(string[] args)
        {

            //3. Create a console application that will accept an arbitrary number test scores(as specified by the user) between 0 and 100, average them,
            //and report a letter grade for the average based on the usual scale.For example, a teacher will input the total number of tests, then input 
            //ten test scores and see the average numerical grade and the letter grade.
            int sum = 0;
            int userInput;
            Console.WriteLine("Enter the no of Test Scores: ");
            int numberOfTests = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                Console.Write("Enter Scores Here between 0 and 100: ");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < 0 || userInput > 100)
                {  
                    Console.WriteLine("Invalid Entry! Please Enter Numbers between 0 and 100");
                }
                else
                { 
                    sum = sum + userInput;
                    i++;
                }
               
            } while ( i != numberOfTests);

            Console.WriteLine("The Average Score is: " + sum/numberOfTests);
            Console.ReadKey();

        }
    }
}

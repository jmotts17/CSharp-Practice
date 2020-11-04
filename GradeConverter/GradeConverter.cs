using System;

namespace GradeConverter
{

    class GradeConverter
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter");

            String response;

            do
            {
                Console.Write("\nEnter numerical grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade >= 88 && grade <= 100)
                {
                    Console.WriteLine("Letter grade: A");
                }
                else if (grade < 88 && grade >= 80)
                {
                    Console.WriteLine("Letter grade: B");
                }
                else if (grade < 79 && grade >= 67)
                {
                    Console.WriteLine("Letter grade: C");
                }
                else if (grade < 67 && grade >= 60)
                {
                    Console.WriteLine("Letter grade: D");
                }
                else if (grade < 60 && grade >= 0)
                {
                    Console.WriteLine("Letter grade: F");
                }
                else
                {
                    Console.WriteLine("Invalid number entered.");
                }

                Console.Write("\nContinue? (y/n): ");
                response = Console.ReadLine();
            } while (response == "y" || response == "Y");

        }
    }
}
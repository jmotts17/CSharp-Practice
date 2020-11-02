using System;

namespace StudentRegistrationPrj
{

    class StudentRegistrationApp
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form\n");

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWelcome " + firstName + " " + lastName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + firstName + "*" + year);
        }
    }
}
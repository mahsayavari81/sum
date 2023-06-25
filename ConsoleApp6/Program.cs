using System;
namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers:");

            //get inputs from user
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            //convert inputs to int
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            //add numbers
            int sum = num1 + num2;

            //print the sum
            Console.WriteLine("\nSum is: " + sum);
        }
    }
}
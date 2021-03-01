
using System;

namespace _1Tutorial02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("Enter Number 01 :");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 02 :");
            number2 = int.Parse(Console.ReadLine());

            int sum = number1 + number2;
            int subtraction = number1 - number2;
            int multiplication = number1 * number2;
            double division = Convert.ToDouble(number1) / Convert.ToDouble(number2); // type casting Converting int to double

            Console.WriteLine("Summation is " + sum);
            Console.WriteLine("Multiplication is " + multiplication);
            Console.WriteLine("Subtraction is " + subtraction);
            Console.WriteLine("Division is " + division);

            Console.ReadKey();
        }


    }
}
}

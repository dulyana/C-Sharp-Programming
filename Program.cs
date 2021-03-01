using System;

namespace _1Tutorial01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int mark;
            char grade;

            Console.WriteLine("Enter your Name:");//Getting user Name
            name = Console.ReadLine();
            Console.WriteLine("Enter your mark:");//Getting user Mark
            mark = int.Parse(Console.ReadLine());
            if (mark>=75 && mark<=100)
            {
                grade = 'A';
            }
            else if (mark>=60 && mark<=74)
            {
                grade = 'B';
            }
            else if (mark>=50 && mark<=59)
            {
                grade = 'C';
            }
            else if (mark>=40 && mark<=49)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine("Hi" + name + "you got" + grade);//Displaying grade with Name

            Console.ReadKey();//Avoid closing the console application.
            
        }
    }
}

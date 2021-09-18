using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Prob_1_Fibonacci_Series
    {
        public static void Fibonacci_Series()
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.Write("Enter a Number :");
           
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (int i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }


        }
    }
}    

//Program.cs file...........
using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
             Prob_1_Fibonacci_Series.Fibonacci_Series();
            
            Console.ReadKey();
        }
    }
}

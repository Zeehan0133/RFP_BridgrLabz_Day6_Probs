using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Prob4_Reverse_Number
    {
        public static void Reverse_Number()
        {
            int rev = 0;
            int rem;
            Console.Write("Pls Enter a Number :");
            int num = Convert.ToInt32(Console.ReadLine());

            while(num!=0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.Write("The Reverse of given number is : ");
            Console.WriteLine(rev);

        }
    }
}
//Program.cs file........
using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
             Prob4_Reverse_Number.Reverse_Number();
           
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Prob3_Prime_Number
    {
        public static void Prime_number()
        {
            int num;
            int count = 0;
            Console.Write("Pls Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine(" Given number is prime Number :");
            }
            else
            {
                Console.WriteLine(" Given number is not a Prime Number :");
            }

        }


    }
}
//Program.cs file.........

using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
           Prob3_Prime_Number.Prime_number();
            
            Console.ReadKey();
        }
    }
}

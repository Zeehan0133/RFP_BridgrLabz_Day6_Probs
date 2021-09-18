using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Prob2_Perfact_Number
    
     {

         public static void Perfact_Number()
         {
             int sum = 0;

             Console.Write("Pls Enter Number : ");
             int num = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= num; i++)
             {
                 if (num % i == 0)
                 {
                     sum = sum + i;

                 }

                 {
                     if (sum == num)
                     {
                         Console.WriteLine($"{num} is perfact number : ");
                     }
                     else
                     {
                         Console.WriteLine($"{num} is not perfact number : ");
                     }
                 }
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
            
             Prob2_Perfact_Number.Perfact_Number();
           
            Console.ReadKey();
        }
    }
}

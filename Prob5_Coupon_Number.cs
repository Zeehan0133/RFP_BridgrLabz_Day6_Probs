using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Prob5_Coupon_Number
    {

        public static void  GenerateCoupon()
        {
            
            Console.WriteLine("Generate Coupon Number");
            int N = Convert.ToInt32(Console.ReadLine()); 
            Random coupon = new Random();
            for (int i = 0; i <= N; i++)
            {




                Console.WriteLine(coupon.Next());
                
            }
        }

    } 
}
//program.cs file....
using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Prob5_Coupon_Number.GenerateCoupon();
          
            Console.ReadKey();
        }
    }
}

using System;

namespace A2_6_Math
{
    class Program
    {
        static void Main()
        {
            decimal diameter;
            decimal circumference;
            decimal area;
            decimal rad;


            Console.WriteLine("enter circle radius");
            rad = decimal.Parse(Console.ReadLine());

            diameter = rad * 2;
            //must read section on pi and on decimals.
            circumference = diameter * 3.14;


            
            Console.WriteLine($"diameter = {diameter}");
        }
    }
}

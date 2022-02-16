using System;

namespace A2_6_Math
{
    class Program
    {
        static void Main()
        {
            double diameter;
            double circ;
            double area;
            double rad;
            double pi = 3.14;
           // double sqr = Math.Pow(rad, 2);
            Console.WriteLine("enter circle radius");
            rad = double.Parse(Console.ReadLine());
            
            diameter = rad * 2;
            //must read section on pi and on decimals.
            circ = diameter * pi;
            area = rad * rad * pi;

            
            Console.WriteLine($"diameter = {diameter}");
            Console.WriteLine($"Circumference = {circ}");
            Console.WriteLine($"area = {area}");
        }
    }
}

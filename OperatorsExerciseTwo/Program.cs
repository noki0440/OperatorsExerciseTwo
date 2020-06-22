using System;

namespace OperatorsExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var add = a + b;
            var sub = a - b;
            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"The sum of {a} and {b} is {add}");
            Console.WriteLine($"The result of {a} minus {b} is {sub}");
            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            Console.WriteLine("What is the radius of your circle ?");
            double realRadius;
            var radius = double.TryParse(Console.ReadLine(), out realRadius);
            var circleArea = CalculateArea(realRadius);

            Console.WriteLine($"The area of a circle with a radius of {realRadius} is {circleArea}");
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}

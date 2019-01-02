using System;

namespace quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            // using c# to solve quadratic equation
            int a, b, c;
            double d, X1, X2;
            // Calculate x1 and x2 of the equation 
            Console.WriteLine("Enter value for a: ");
            a = Int32 .Parse(Console .ReadLine());
            Console.WriteLine("Enter value for b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for c: ");
            c = Int32.Parse(Console.ReadLine());
            d = (b*b) - (4 * a * c);
            // going to the equation proper using the if and else statements.
            if (d > 0)
            {
                X1 = ((-b + Math.Sqrt(d)) / (2 * a));
                X2 = ((-b - Math .Sqrt (d))/ (2*a));
                Console.WriteLine("The roots of the equation are: {0}; {1};", X1 , X2);
            }
            else if (d == 0)
            {
                Console.WriteLine("The roots are equal ");
                X1 = X2 = -b / (2*a);
                Console.WriteLine("therefore X = {0};", X1);

            }
            else
            {
                Console.WriteLine("No Solution");
            }
            Console.ReadLine();
        }
    }
}

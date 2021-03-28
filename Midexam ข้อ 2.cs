using System;

namespace Midterm_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b , x, y ;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int run = 0;
            Console.Write("x");
           x = a;
           y = b;

            while (run == 0)
            {
                if (x == y)
                {
                    Console.WriteLine("x");                   
                }
                else
                {
                    if (x < y)
                    {
                        Console.WriteLine(x = x + a);
                    }
                    else
                    {
                        Console.WriteLine(y = y + b);
                    }
                }
            }
            
        }
    }
}

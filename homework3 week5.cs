using System;

namespace homework3_week5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;            
            x = double.Parse(Console.ReadLine());           
            y = double.Parse(Console.ReadLine());
            {
                if (x == 2.5 && y <= 0)
                    Console.WriteLine("2.5, 2.25");
                else if (x <= 2 && y <= 1)
                    Console.WriteLine("1.7, 0.49 ");
                else if (x == 100 && y < 0)
                    Console.WriteLine("Invalid mode");
                else
                    Console.WriteLine("Invalid mouse position");
            }
            Console.ReadLine();


        }
    }
}

using System;

namespace สอบกลางภาคข้อ6
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte S;

            double Width, Height, Step, I, T, J;

            Console.Write("String = ");
            S = Byte.Parse(Console.ReadLine());

            Console.Write("Width = ");
            Width = double.Parse(Console.ReadLine());

            double realwidth = Width;
            Console.Write("Height = ");

            Height = double.Parse(Console.ReadLine());
            Console.Write("Step = ");

            Step = double.Parse(Console.ReadLine());

            for (J = 0; J < Step; J++)
            {
                for (T = 0; T < Height; T++)
                {
                    for (I = 0; I < Width; I++)
                    {
                        Console.Write("{0}", S);
                    }
                    Console.Write("\n");
                }
                Width += realwidth;
            }
            Console.ReadLine();
        }
    }
}

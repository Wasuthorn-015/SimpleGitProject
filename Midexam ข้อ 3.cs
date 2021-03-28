using System;

namespace Midexam
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, amountofBox, Nopail,
                Playerwin = 0, i = 0;
            Console.WriteLine("input pail1 ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("input Pail2 ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("input Pail3 ");
            c = int.Parse(Console.ReadLine());

            while (i == 0)
            {
                if (a <= 0 && b <= 0 && c <= 0)
                {
                    i = 1;
                    if (Playerwin % 2 == 0)
                    {
                        Console.WriteLine("Player A is winner <3 ");
                    }
                    else
                    {
                        Console.WriteLine("Player B is winner <3 ");
                    }
                }
                else
                {
                    Console.WriteLine("What you gonna pick?");
                    Console.WriteLine("Pail 1|Pail 2 |Pail 3");
                    amountofBox = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many box you pick?");
                    Nopail = int.Parse(Console.ReadLine());

                    Playerwin++;
                    if (Nopail == 1 || Nopail == 2)
                    {
                        if (amountofBox == 1) { Console.Write(a = a - Nopail); }
                        if (amountofBox == 2) { Console.Write(b = c - Nopail); }
                        if (amountofBox == 3) { Console.Write(c = c - Nopail); }
                    }
                    else
                    {
                        Console.WriteLine("input again");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

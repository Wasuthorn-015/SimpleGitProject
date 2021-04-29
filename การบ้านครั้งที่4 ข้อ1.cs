using System;

namespace การบ้าน4_ข้อ1
{
    class Program
    {
        static void Main(string[] args)
        {
          bool Check = false;

            while (Check != true)
            {
                int Pattern;
                Pattern = int.Parse(Console.ReadLine());

                if (Pattern >= 0)
                {
                    Row(Pattern);

                    Check = true;
                }
                else
                {
                    Console.WriteLine("Invalid Pascal’s triangle row number.");
                }
            }
        }


        static void Row(int row)
        {
            int N = 1, X, Y;

            for (X = 0; X <= row; X++)
            {
                for (Y = 0; Y <= X; Y++)
                {
                    if (Y == 0 || X == 0)
                    {
                        N = 1;
                    }
                    else
                    {
                        N = N * (X - Y + 1) / Y;
                        Console.Write("{0}  ", N);
                    }
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}

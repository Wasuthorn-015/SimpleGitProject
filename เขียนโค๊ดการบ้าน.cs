using System;

namespace week3ver100
{
    class Program
    {
        static void Main(string[] args)
        {
            int code;
            string company;
            Console.Write("Input Code :");
            code = int.Parse(Console.ReadLine());
            Console.Write("Input your Company : ");
            company = Console.ReadLine();
            if (company == "CIA")
            {
                bool checkone = (code - 3) % 10 == 0 || (code - 6) % 10 == 0 || (code - 9) % 10 == 0;
                bool checktwo = checkone && (code % 100) / 10 != 1 &&
                                (code % 100) / 10 != 3 &&
                                (code % 100) / 10 != 5;
                bool checkthree = checktwo && (code % 10000) / 1000 >= 6 &&
                                   (code % 10000) / 1000 != 8;
                Console.Write(checkthree);

            }
            else if (company == "NSA")
            {
                bool checkone = 30 % (code % 10) == 0;
                bool checktwo = checkone && (code % 10000) % 3 == 0 &&
                                (code % 10000) % 2 == 1
                                ;
                bool checkthree = checktwo && code % 10 == 7 ||
                                  (code % 100) / 10 == 7 || (code % 1000) / 100 == 7 ||
                                  (code % 10000) / 1000 == 7 ||
                                  (code % 100000) / 10000 == 7 ||
                                  (code % 1000000) / 100000 == 7
                                  ;
                Console.Write(checkthree);
            }
            else if (company == "FBI")
            {
                bool ckeckone = (code % 1000000) / 10000 >= 4 && (code % 1000000) / 100000 <= 7;
                bool checktwo = ckeckone && (code % 1000) / 100 == 2 || (code % 1000) / 100 == 4 ||
                                (code % 1000) / 100 == 8;
                bool checkthree = checktwo && ((code % 100000) / 10000) % 2 == 1
                                  ;
                Console.Write(checkthree);
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}

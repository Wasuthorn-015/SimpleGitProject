using System;

namespace สอบกลางภาคข้อ3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            float filmBackWidth;
            Console.Write("String = ");
            mode = Console.ReadLine();
            double j = 1;
            while (j == 1)
            {
                Console.Write("filmBackWidth : ");
                filmBackWidth = float.Parse(Console.ReadLine());
                if (filmBackWidth > 0)
                {
                    double fLength, fov;
                    if (mode == "fLength")
                    {
                       j = 1;
                        while (j == 1)
                        {
                            Console.WriteLine("fLength = ");
                            fLength = double.Parse(Console.ReadLine());
                            if (fLength > 0)
                            {
                                fov = 2 * (Math.Atan(filmBackWidth / (2 * fLength)));

                                Console.WriteLine("fLength = {0},fov = {1}", fLength, fov);
                                j = 2;
                            }
                            else
                            {
                                Console.Write("Invalid fLength. Please input again");
                            }
                        }
                    }
                    else
                    {
                        if (mode == "fov")
                        {
                            j = 1;
                            while (j == 1)
                            {
                                Console.WriteLine("fov = ");
                                fov = float.Parse(Console.ReadLine());
                                if (fov > 0.1 && fov < 6.28)
                                {
                                    fLength = filmBackWidth / (2 * Math.Tan(fov / 2));
                                    Console.WriteLine("fLength = {0},fov = {1}", fLength, fov);
                                    j = 2;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid fov.Please input again");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid filmBackWidth. Please input again\n");
                }
            }
            Console.ReadLine();
        }
    }
}

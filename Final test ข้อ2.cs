using System;

namespace Final_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            int[] NumSort = new int[99];
            Console.WriteLine("NumSort : ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("inputNum " + i + ":");
                NumSort[i] = int.Parse(Console.ReadLine());
            }
            ////01
            int[] a = new int[30];
            for (i = 1; i <= n; i++)
            {
                a[i] = NumSort[i];
            }
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("First Sort :");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine("\n");

            ////02
            Console.WriteLine("Second Sort : ");
            int[] b = new int[30];
            for (i = 1; i <= n; i++)
            {
                b[i] = NumSort[i];
            }
            ///
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (b[i] > b[j])
                    {
                        int temp = b[j];
                        b[j] = b[i];
                        b[i] = temp;
                    }
                }
            }
            ////print
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(b[i] + " ");
            }
            Console.WriteLine("\n");

            ////03
            Console.WriteLine("Third Sort : ");
            int[] c = NumSort;
            for (i = 1; i <= n; i++)
            {
                c[i] = NumSort[i];
            }
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(c[i] + " ");
            }
            Console.WriteLine("\n");
            Array.Sort(NumSort);
            Array.Reverse(NumSort);
            foreach (int value in NumSort)
            {
                Console.WriteLine(value + " ");
            }

        }    
    }
}

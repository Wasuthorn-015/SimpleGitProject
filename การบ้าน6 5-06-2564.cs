using System;

namespace การบ้านครั้งที่6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLevel, nMenu, numProblem, Ans;
            long T1, T2, Time;
            double S = 0, S1, Qc = 0, Qa = 0, D_Lv = 0;
            Difficulty LV = Difficulty.Easy;

            Console.Write("Score: {0}, Difficulty: {1}", S, LV);
            Console.Write("Select Menu 0 / 1 / 2");
            nMenu = int.Parse(Console.ReadLine());
            while (nMenu != 2)
            {
                switch (nMenu)
                {
                    case 0:
                        T1 = DateTimeOffset.Now.ToUnixTimeSeconds();
                        if (LV == Difficulty.Easy)
                        {
                            numProblem = 3;
                            for (int i = 0; i < 3; i++)
                            {
                                GenerateRandomProblems(numProblem);
                                Problem[] random = GenerateRandomProblems(numProblem);
                                Console.Write(random[i].Message);
                                Console.Write("");
                                Ans = int.Parse(Console.ReadLine());
                                if (Ans == random[i].Answer)
                                {
                                    Qc = Qc +1
                                }
                                Qa = 3;decimal Lv = 0;
                            }
                        }
                }
            }
            
        }
    }
}

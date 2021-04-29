using System;

namespace การบ้าน4_ข้อ2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool CheckLoopSystem = false;

            while (CheckLoopSystem != true)
            {
                char YorN;
                Console.Write("Please! Input DNA : ");

                string halfDNASequence = Console.ReadLine();

                bool CheckHalfDNASequence = IsValidSequence(halfDNASequence);

                bool CheckLoopHalfDNASequence = false;

                if (CheckHalfDNASequence == true)
                {
                    Console.Write("Current half DNA sequence : " + halfDNASequence);

                    while (CheckLoopHalfDNASequence == false)
                    {
                        Console.Write("Do you want to replicate it ? (Y or N) : ");

                        YorN = char.Parse(Console.ReadLine());


                        if (YorN == 'Y')
                        {
                            string y = ReplicateSeqeunce(halfDNASequence);

                            Console.Write("Replicated half DNA sequence: " + y);

                            CheckLoopHalfDNASequence = true;
                        }
                        else if (YorN == 'N')
                        {
                            CheckLoopHalfDNASequence = true;
                        }
                        else
                        {
                            Console.Write("Please Input Y or N.");
                        }
                    }
                }
                else if (CheckHalfDNASequence == false)
                {
                    Console.Write("That half DNA sequence is invalid.");

                    while (CheckLoopHalfDNASequence != true)
                    {
                        Console.Write("Do you want to process another sequence? (Y or N) : ");

                        YorN = char.Parse(Console.ReadLine());
                        if (YorN == 'Y')
                        {
                            CheckLoopHalfDNASequence = true;
                        }
                        else if (YorN == 'N')
                        {
                            CheckLoopHalfDNASequence = true;

                            CheckLoopSystem = true;
                        }
                        else
                            Console.Write("Please input Y or N.");
                    }
                }

            }
        }

        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
    }
}

using System;
using System.Linq;

namespace kaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bestDnaSequence = new int[n];
            int bestCounter = -1;
            int bestSum = 0;
            int bestIndex = -1;
            int bestSequenceIndex = 0;
            int currentSequenceIndex = 0;
            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                bool isBest = false;
                int[] currentDnaSequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentCounter = 0;
                int counter = 0;
                int currentSum = 0;
                int startIndex = 0;
                currentSequenceIndex++;
                for (int i = 0; i < n; i++)
                {
                    if (currentDnaSequence[i] != 1)
                    {
                        counter = 0;
                        continue;
                    }

                    counter++;
                    if (counter > currentCounter)
                    {
                        currentCounter = counter;
                        startIndex = i;
                    }
                }

                currentSum = currentDnaSequence.Sum();
                if (currentCounter > bestCounter)
                {
                    isBest = true;
                }

                else if (currentCounter == bestCounter)
                {
                    if (startIndex < bestIndex)
                    {
                        isBest = true;
                    }

                    else if (startIndex == bestIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            isBest = true;
                        }
                    }
                }

                if (isBest)
                {
                    bestCounter = currentCounter;
                    bestDnaSequence = currentDnaSequence;
                    bestSum = currentSum;
                    bestIndex = startIndex;
                    bestSequenceIndex = currentSequenceIndex;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", bestDnaSequence)}");
        }
    }
}
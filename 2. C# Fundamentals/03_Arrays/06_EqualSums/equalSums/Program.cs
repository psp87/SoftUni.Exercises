using System;
using System.Linq;

namespace equalSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //left sum
                for (int k = 0; k <= i-1; k++)
                {
                    leftSum += arr[k];
                }
                //right sum

                for (int m = i+1; m < arr.Length; m++)
                {
                    rightSum += arr[m];
                }

                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }

                leftSum = 0;
                rightSum = 0;
            }
            if (leftSum != rightSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}

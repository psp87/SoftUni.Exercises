using System;

namespace arrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int rotationNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationNumber; i++)
            {
                string temp = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    arr[j-1] = arr[j];
                }
                arr[arr.Length-1] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

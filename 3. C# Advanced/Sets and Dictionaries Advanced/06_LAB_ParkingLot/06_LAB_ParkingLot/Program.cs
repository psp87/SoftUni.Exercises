using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_LAB_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var parking = new HashSet<string>();

            while (input != "END")
            {
                string[] inputSplited = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string direction = inputSplited[0];
                string carNumber = inputSplited[1];

                if (direction == "IN")
                {
                    parking.Add(carNumber);
                }
                else
                {
                    parking.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (parking.Any())
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_AutoRepairAndService
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] models = Console.ReadLine().Split();

            Stack<string> servedCars = new Stack<string>();

            Queue<string> cars = new Queue<string>(models);

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputSplited = input.Split("-");

                string command = inputSplited[0];

                if (command == "Service")
                {
                    if (cars.Any())
                    {
                        string currentCar = cars.Dequeue();
                        servedCars.Push(currentCar);

                        Console.WriteLine($"Vehicle {currentCar} got served.");
                    }
                }

                else if (command == "CarInfo")
                {
                    string modelName = inputSplited[1];

                    if (cars.Contains(modelName))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }

                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }

                else if (command == "History")
                {
                    if (servedCars.Any())
                    {
                        Console.WriteLine(String.Join(", ", servedCars));
                    }
                }

                input = Console.ReadLine();
            }

            if (cars.Any())
            {
                Console.Write("Vehicles for service: ");
                Console.WriteLine(String.Join(", ", cars));
            }

            Console.Write("Served vehicles: ");
            Console.WriteLine(String.Join(", ", servedCars));
        }
    }
}   

using System;
using System.Collections.Generic;

namespace _04_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsDict = new Dictionary <string, double[]>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] inputSplited = input.Split(" ");

                string productName = inputSplited[0];
                double productPrice = double.Parse(inputSplited[1]);
                double productQuantity = double.Parse(inputSplited[2]);

                if (!productsDict.ContainsKey(productName))
                {
                    productsDict.Add(productName, new double[2]);
                }

                productsDict[productName][0] += productQuantity;
                productsDict[productName][1] = productPrice;

                input = Console.ReadLine();
            }

            foreach (var kvp in productsDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value[0] * kvp.Value[1]:F2}");
            }
        }
    }
}

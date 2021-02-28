using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputSplited = input.Split(" ");

                string name = inputSplited[0];
                string id = inputSplited[1];
                int age = int.Parse(inputSplited[2]);

                var people = new People(name, id, age);
                peoples.Add(people);

                input = Console.ReadLine();
            }

            peoples = peoples.OrderBy(x => x.Age).ToList();

            Console.WriteLine(String.Join(Environment.NewLine, peoples));
        }
    }

    class People
    {
        public People(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString()   
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}

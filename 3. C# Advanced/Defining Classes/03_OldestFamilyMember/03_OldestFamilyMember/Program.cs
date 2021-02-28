
namespace DefiningClasses
{
    using System;
    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split();

                string name = inputTokens[0];
                int age = int.Parse(inputTokens[1]);

                Person person = new Person(name, age);
                family.AddMemeber(person);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}

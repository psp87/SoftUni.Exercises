using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person otherPerson = new Person("Pesho");

            person.Name = "Stamat";
        }
    }
}

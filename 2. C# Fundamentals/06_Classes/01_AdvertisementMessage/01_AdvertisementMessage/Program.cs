using System;

namespace _01_AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!"
                    , "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                int phraseIndex = rnd.Next(0, phrases.Length);
                string phrase = phrases[phraseIndex];
                int eventIndex = rnd.Next(0, events.Length);
                string eve = events[eventIndex];
                int authorIndex = rnd.Next(0, authors.Length);
                string author = authors[authorIndex];
                int cityIndex = rnd.Next(0, cities.Length);
                string city = cities[cityIndex];

                Console.WriteLine($"{phrase} {eve} {author} - {city}.");
            }
        }
    }
}

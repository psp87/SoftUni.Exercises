using System;

namespace Exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int countGames = int.Parse(Console.ReadLine());

            double volleyPoints = 0;
            double tennisPoints = 0;
            double badmigtonPoints = 0;

            int counterVolley = 0;
            int counterTennis = 0;
            int counterBadmington = 0;

            for (int i = 0; i < countGames; i++)
            {
                string gameName = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());

                if (gameName == "volleyball")
                {
                    volleyPoints += points + 0.07 * points;
                    counterVolley++;
                }

                else if (gameName == "tennis")
                {
                    tennisPoints += points + 0.05 * points;
                    counterTennis++;
                }

                else if (gameName == "badminton")
                {
                    badmigtonPoints += points +  0.02 * points;
                    counterBadmington++;
                }
            }

            double averageVolleyPoints = Math.Floor(volleyPoints / counterVolley);
            double averageTennisPoints = Math.Floor(tennisPoints / counterTennis);
            double averageBadmingtonPoints = Math.Floor(badmigtonPoints / counterBadmington);

            double totalPoints = volleyPoints + tennisPoints + badmigtonPoints;
            totalPoints = Math.Floor(totalPoints);

            if (averageBadmingtonPoints >= 75 && averageTennisPoints >= 75 && averageBadmingtonPoints >= 75)
            {
                Console.WriteLine($"Congratulations, {playerName}! You won the cruise games with {totalPoints} points.");
            }

            else
            {
                Console.WriteLine($"Sorry, {playerName}, you lost. Your points are only {totalPoints}.");
            }
        }
    }
}

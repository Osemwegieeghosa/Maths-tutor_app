using System;
using System.IO;

namespace MathsTutor
{
    public class Statistics
    {
        private static string statisticsFile = "statistics.txt";

        public static void UpdateStatistics(int numCards, bool isCorrect)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(statisticsFile, true))
                {
                    writer.WriteLine($"{DateTime.Now}\t{numCards} cards\t{(isCorrect ? "Correct" : "Incorrect")}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while updating the statistics: {e.Message}");
            }
        }

        public static void DisplayStatistics()
        {
            try
            {
                using (StreamReader reader = new StreamReader(statisticsFile))
                {
                    Console.WriteLine("Statistics:\n");
                    Console.WriteLine("Date\t\t\tCards\tResult");
                    Console.WriteLine("-----------------------------------------");

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No statistics found.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while reading the statistics: {e.Message}");
            }
        }
    }
}
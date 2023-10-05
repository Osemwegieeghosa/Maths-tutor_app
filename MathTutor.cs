using System;
using System.IO;
using System.Collections.Generic;

namespace MathsTutor
{
    class MathsTutor
    {
        private static string statisticsFile = "statistics.txt";

        static void Main(string[] args)
        {
            bool quit = false;
            Pack pack = new Pack();
            pack.Shuffle();

            while (!quit)
            {
                Tutorial.ShowInstructions();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Tutorial.ShowInstructions();
                        break;
                    case "2":
                        PlayGame(pack, 3);
                        break;
                    case "3":
                        PlayGame(pack, 5);
                        break;
                    case "4":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }

            Tutorial.ShowGoodbye();
        }

        static void PlayGame(Pack pack, int numCards)
        {
            List<Card> cards = pack.Deal(numCards);
            Tutorial.ShowDeal(cards);

            try
            {
                int answer = int.Parse(Console.ReadLine());
                bool isCorrect = CheckAnswer(cards, answer);
                Tutorial.ShowResult(isCorrect);

                // Update statistics
                UpdateStatistics(numCards, isCorrect);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static bool CheckAnswer(List<Card> cards, int answer)
        {
            int num1 = cards[0].GetValue();
            int num2 = cards[2].GetValue();
            int num3 = cards.Count == 5 ? cards[4].GetValue() : 0;
            string op1 = cards[1].GetSuitString();
            string op2 = cards.Count == 5 ? cards[3].GetSuitString() : "";

            int expectedAnswer;
            if (cards.Count == 3)
            {
                expectedAnswer = EvaluateExpression(num1, num2, op1);
            }
            else
            {
                expectedAnswer = EvaluateExpression(EvaluateExpression(num1, num2, op1), num3, op2);
            }

            return answer == expectedAnswer;
        }

        static int EvaluateExpression(int num1, int num2, string op)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return 0;
            }
        }

        static void UpdateStatistics(int numCards, bool isCorrect)
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
    }
}
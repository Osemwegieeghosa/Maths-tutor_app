using System;

namespace MathsTutor
{
    public class MathsProblem
    {
        public static void DealThreeCards()
        {
            Console.WriteLine("Dealing 3 cards...");
            Card card1 = GenerateRandomCard();
            Card card2 = GenerateRandomCard();
            Card card3 = GenerateRandomCard();

            Console.WriteLine($"1st card: {card1.GetValue()}");
            Console.WriteLine($"2nd card: {card2.GetSuitString()}");
            Console.WriteLine($"3rd card: {card3.GetValue()}");

            int result = EvaluateExpression(card1, card2, card3);
            Console.WriteLine($"Result: {result}");
        }

        public static void DealFiveCards()
        {
            Console.WriteLine("Dealing 5 cards...");
            Card card1 = GenerateRandomCard();
            Card card2 = GenerateRandomCard();
            Card card3 = GenerateRandomCard();
            Card card4 = GenerateRandomCard();
            Card card5 = GenerateRandomCard();

            Console.WriteLine($"1st card: {card1.GetValue()}");
            Console.WriteLine($"2nd card: {card2.GetSuitString()}");
            Console.WriteLine($"3rd card: {card3.GetValue()}");
            Console.WriteLine($"4th card: {card4.GetSuitString()}");
            Console.WriteLine($"5th card: {card5.GetValue()}");

            int result = EvaluateExpression(card1, card2, card3, card4, card5);
            Console.WriteLine($"Result (using BODMAS): {result}");
        }

        private static Card GenerateRandomCard()
        {
            Random random = new Random();
            int value = random.Next(1, 14);
            int suit = random.Next(1, 5);
            return new Card(value, suit);
        }

        private static int EvaluateExpression(params Card[] cards)
        {
            int result = cards[0].GetValue();
            for (int i = 1; i < cards.Length; i += 2)
            {
                string op = cards[i].GetSuitString();
                int num = cards[i + 1].GetValue();

                switch (op)
                {
                    case "+":
                        result += num;
                        break;
                    case "-":
                        result -= num;
                        break;
                    case "*":
                        result *= num;
                        break;
                    case "/":
                        result /= num;
                        break;
                }
            }
            return result;
        }

        internal static int EvaluateExpression(Card card1, Card card2, Card card3, Card card4, Card card5, Card card6, Card card7)
        {
            throw new NotImplementedException();
        }
    }
}
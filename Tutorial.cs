using System;
using System.Collections.Generic;

namespace MathsTutor
{
    public class Tutorial
    {
        public static void ShowInstructions()
        {
            Console.WriteLine("Welcome to the Maths Tutor!\n");
            Console.WriteLine("Choose an option from the menu below:");
            Console.WriteLine("1. Instructions");
            Console.WriteLine("2. Deal 3 cards (2 numbers + operator)");
            Console.WriteLine("3. Deal 5 cards (3 numbers + 2 operators)");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter the number of your choice:");
        }

        public static void ShowGoodbye()
        {
            Console.WriteLine("\nThank you for using the Maths Tutor!");
        }

        public static void ShowDeal(List<Card> cards)
        {
            Console.WriteLine("\nDeal [Value, Suit]:");
            foreach (Card card in cards)
            {
                Console.Write($"[{card.GetValue()}, {card.GetSuitString()}] ");
            }
            Console.WriteLine();

            if (cards.Count == 3)
            {
                int num1 = cards[0].GetValue();
                int num2 = cards[2].GetValue();
                string op = cards[1].GetSuitString();

                Console.Write($"{num1} {op} {num2} = ");
            }
            else if (cards.Count == 5)
            {
                int num1 = cards[0].GetValue();
                int num2 = cards[2].GetValue();
                int num3 = cards[4].GetValue();
                string op1 = cards[1].GetSuitString();
                string op2 = cards[3].GetSuitString();

                Console.Write($"{num1} {op1} {num2} {op2} {num3} = ");
            }
        }

        public static void ShowResult(bool isCorrect)
        {
            if (isCorrect)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }
    }
}
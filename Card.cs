using System;

namespace MathsTutor
{
    public class Card
    {
        private int value;
        private int suit;
        internal static readonly object Suits;

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public int GetValue()
        {
            return this.value;
        }

        public int GetSuit()
        {
            return this.suit;
        }

        public string GetSuitString()
        {
            switch (this.suit)
            {
                case 1:
                    return "+";
                case 2:
                    return "-";
                case 3:
                    return "*";
                case 4:
                    return "/";
                default:
                    return "";
            }
        }
    }
}
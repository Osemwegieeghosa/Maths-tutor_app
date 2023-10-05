using System;
using System.Collections.Generic;

namespace MathsTutor
{
    public class Pack
    {
        private List<Card> cards;

        public Pack()
        {
            this.cards = new List<Card>();

            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    this.cards.Add(new Card(value, suit));
                }
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            int n = this.cards.Count;

            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card card = this.cards[k];
                this.cards[k] = this.cards[n];
                this.cards[n] = card;
            }
        }

        public List<Card> Deal(int numCards)
        {
            List<Card> dealtCards = new List<Card>();

            for (int i = 0; i < numCards; i++)
            {
                Card card = this.cards[0];
                this.cards.RemoveAt(0);
                dealtCards.Add(card);
            }

            return dealtCards;
        }
    }
}
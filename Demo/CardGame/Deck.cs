using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo.CardGame
{
    public class Deck
    {
        public List<Card> cards;
        public Hand player;
        public Deck()
        {
            InitialCards();
            Shuffle();
            DealCards();
            player.Sort();
            Console.WriteLine("排序后的牌{0}",player.ToString());
        }
        public void Shuffle()
        {
            List<Card> newListCard = new List<Card>();
            Random random = new Random();
            for (int i = 0; i < 52; i++)
            {
                Card c = cards[random.Next(0, cards.Count - 1)];
                newListCard.Add(c);
                cards.Remove(c);
            }
            cards = newListCard;
        }
        private void InitialCards()
        {
            cards = new List<Card>();
            foreach (CardSuits cs in Enum.GetValues(typeof(CardSuits)))
            {
                foreach (CardValues cv in Enum.GetValues(typeof(CardValues)))
                {
                    cards.Add(new Card(cs, cv));
                }
            }
        }
        public void DealCards()
        {
            player=new Hand();
            for(int i=0;i<13;i++)
            {
                player.cards.Add(this.cards[i]);
            }
            Console.WriteLine("玩家手中的牌为{0}",player.ToString());
        }
    }
}
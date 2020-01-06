using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo.CardGame
{
    public class Hand:IComparer<Card>
    {
        public List<Card> cards = new List<Card>(); 
        public  void Sort()
        {
            cards.Sort(this);
        } 
        public int Compare(Card x, Card y)
        {   
            if (x.suit != y.suit)
                return System.Collections.Comparer.Default.Compare(y.suit, x.suit);
            else return System.Collections.Comparer.Default.Compare(x.val, y.val);
        }
        public override string ToString()
        {
            string result="";
            foreach(Card c in this.cards)
            {
                result+=c.ToString()+",";
            }
            return result;
        } 
    }
 
}
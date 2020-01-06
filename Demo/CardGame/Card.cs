using System;
using System.Collections;

namespace Demo.CardGame
{
     public enum CardSuits
    {
        Spade,
        Heart,
        Diamond,
        Club
    }

    public enum CardValues
    {
        Ace, Deuce, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }
    public class Card
    {
        public CardSuits suit;
        public CardValues val;
        public Card(CardSuits suit, CardValues val)
        {
            this.suit = suit;
            this.val = val;
        }
        public override string ToString()
        {
            string suit="";
            if(this.suit==CardSuits.Spade)suit="♠️";
            else if(this.suit==CardSuits.Heart)suit="♥️";
            else if(this.suit==CardSuits.Diamond)suit="♦️";
            else suit="♣️";
            return suit+this.val.ToString();
        } 
    }
}
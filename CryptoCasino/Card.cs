using System;

namespace CryptoCasino
{
    public enum Suit
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    public enum Colour
    {
        Black,
        Red
    }

    public class Card
    {
        public Suit Suit { get; set; }
        public char SuitChar => Suit switch
        {
            Suit.Club => '♣',
            Suit.Diamond => '♦',
            Suit.Heart => '♥',
            Suit.Spade => '♠',
            _ => throw new NotImplementedException($"A non-existent case exists for converting Suit enum to respective char.")
        };

        public string Value { get; set; }
        public Colour Colour => Suit switch
        {
            Suit.Club => Colour.Black,
            Suit.Spade => Colour.Black,
            Suit.Diamond => Colour.Red,
            Suit.Heart => Colour.Red,
            _ => throw new NotImplementedException($"A non-existent case exists for converting Suit enum to respective colour.")
        };

        public Card(Suit suit, string value)
        {
            Suit = suit;
            Value = value;
        }
    }
}

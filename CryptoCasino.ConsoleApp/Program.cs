using System;

namespace CryptoCasino.ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Card card1 = new Card(Suit.Club, "A");
            Card card2 = new Card(Suit.Diamond, "7");
            Card card3 = new Card(Suit.Heart, "10");
            Card card4 = new Card(Suit.Spade, "Q");
        }
    }
}

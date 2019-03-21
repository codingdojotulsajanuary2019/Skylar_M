using System;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck Deck1 = new Deck();
            Card DrawnCard = Deck1.Deal();
            Deck1.Shuffle();
            Card DrawnCard2 = Deck1.Deal();
            DrawnCard.GetInfo();
            DrawnCard2.GetInfo();
        }
    }
}

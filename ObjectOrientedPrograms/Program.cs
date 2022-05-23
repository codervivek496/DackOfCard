using System;

namespace ObjectOrientedPrograms
{
    class program
    {
        public static void Main(string[] args)
        {
            DeckOfCards deckOfCards = new DeckOfCards();
            deckOfCards.Shuffle();
            deckOfCards.Display();
        }
    }
}

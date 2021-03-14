using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            /*deck = Shuffle(deck);*/  //calling the method we made below to shuffle

            //to iterate each card to get all 52, easiest fastest way after making the constructor on Deck class
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count); //Count will show how many in total was instantiated

            //deck.Cards = new List<Card>();

            //Add 1 card to a deck, takes a lot of time to do below
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);

            //Card cardOne = new Card();

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            Console.ReadLine();
        }

        public static Deck Shuffle (Deck deck)  //static bc we dont want to create object program before calling this, this is a method
        {
            List<Card> TempList = new List<Card>(); //temp list to store shuffle results
            Random random = new Random();

            while (deck.Cards.Count > 0)  //take cards until the count is 0
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //min is 0 max is the count of deck which is 52 cards
                TempList.Add(deck.Cards[randomIndex]); //now we add it to the temp list
                deck.Cards.RemoveAt(randomIndex); //then remove if from the base list until no card left
            }

            deck.Cards = TempList;
            return deck;
        }
    }
}

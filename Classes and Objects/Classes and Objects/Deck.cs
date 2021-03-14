using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    public class Deck
    {
        public Deck() //instructor to a new deck, inside of a class is an constructor
        {
            //below is not the easiest way, this method uses a manual one by one approach to create 52 cards
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

            Cards = new List<Card>(); //instantiate the list of cards of that class, to create a list of foreach results
            
            //foreach loop, iteration through each list to pair, best way and simplest way
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //Do this to go through the list to pair them
            foreach (string face in Faces) //Faces should go first to pair with Suits to get 2 of spades etc
            {
                foreach (string suit in Suits) //base of the foreach loop to iterate
                {
                    Card card = new Card();
                    card.Suit = suit; //e.g. iterate first with Clubs then Twos Threes
                    card.Face = face; //e.g. assign the "faces: value to the suit assigned above
                    Cards.Add(card);  //adding all the result of iteration using the card foreach
                }
            }

        }
        public List<Card> Cards { get; set; }
    }
}

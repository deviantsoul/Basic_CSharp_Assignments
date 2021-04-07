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

        //removed static = call this method without applying to specific deck/class
        //removed out parameter
        //got rid of Deck as we are operating on Deck itself
        public void Shuffle(int times = 1)  //static bc we dont want to create object program before calling this, this is a method
        {
            //setting the default value of timeShuffled
            
            for (int i = 0; i < times; i++) //put the while loop inside the for loop after adding int times
            {
                //to increment timeShuffled each time loop is happening
                
                List<Card> TempList = new List<Card>(); //temp list to store shuffle results
                Random random = new Random();

                while (Cards.Count > 0)  //take cards until the count is 0
                {
                    int randomIndex = random.Next(0, Cards.Count); //min is 0 max is the count of deck which is 52 cards
                    TempList.Add(Cards[randomIndex]); //now we add it to the temp list
                    Cards.RemoveAt(randomIndex); //then remove if from the base list until no card left
                }

                Cards = TempList;
            }

        }
    }
}

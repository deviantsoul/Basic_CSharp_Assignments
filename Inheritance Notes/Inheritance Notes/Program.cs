using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            //class is a reference type and struct is a value type
            //inherit the game class to specific game like TwentyOne
            //TwentyOneGame game = new TwentyOneGame();

            //Polymorphism is the ability of the class to morph into its inherited class that gives certain advantages
            //Game game = new TwentyOneGame(); <---sample polymorphism in case there's more than 1 game

            //another way to initialize object
            //game.Players = new List<string>() { "Hans", "Paisely", "Laura" };
            //game.Listplayers();
            ////game.Play();
            //Console.ReadLine();          

            

            Deck deck = new Deck();
            deck.Shuffle(19);

            ////in order to count all Aces in Card
            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //}

            //or use LAMBDA

            int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //Console.WriteLine(counter);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);

            Console.ReadLine();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>(); //<---- instantiate first before using the operator overload
            //Player player = new Player();
            //player.Name = "Paisely";
            ////long way to do operator overload
            ////game = game + player;
            ////game = game - player;
            //game += player;
            //game -= player; //<--removes it again

            //game.Listplayers();

            //Console.ReadLine();

        }
    }
}

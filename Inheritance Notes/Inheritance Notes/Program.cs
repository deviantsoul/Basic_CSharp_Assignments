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
            //inherit the game class to specific game like TwentyOne
            TwentyOneGame game = new TwentyOneGame();

            //another way to initialize object
            game.Players = new List<string>() { "Hans", "Paisely", "Laura" };
            game.Listplayers();
            game.Play();
            Console.ReadLine();
        }
    }
}

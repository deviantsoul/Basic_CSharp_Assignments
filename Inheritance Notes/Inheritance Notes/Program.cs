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
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Hans", "Paisely", "Laura" };
            game.Listplayers();
            game.Play();
            Console.ReadLine();
        }
    }
}

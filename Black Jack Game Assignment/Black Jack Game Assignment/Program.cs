using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Black_Jack_Game_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText("C:\\Users\\ucabh\\Desktop\\Basic_CSharp_Assignments\\Logs\\log.txt", text);
            ///<!--To read the the log text or any text file-->
            ///File.ReadAllText("C:\\Users\\ucabh\\Desktop\\Basic_CSharp_Assignments\\Logs\\log.txt");
            Console.WriteLine("Welcome to the NeverEnding Casino. And to whom do I owe the pleasure?");
            string playerName = Console.ReadLine();

            //exception handling the invalid amount
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much moola you have today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only with no decimals.");
                if (bank < 0)
                {
                    Console.WriteLine("Bye bye. You don't have enough money to play.");
                    Console.ReadLine();
                    return;
                }
            }
            

            ///Removed because of exception handling
            ///Console.WriteLine("And how much moola you have today?");
            ///int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}. You can only play game of 21 right now because of your reputation. Would like to? ", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yizz" || answer == "ye")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\ucabh\Desktop\Basic_CSharp_Assignments\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);                    
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Someone will be with you shortly. Please stay where you are!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator.");
                        Console.ReadLine();
                        return;
                    }
                    
                }

                game -= player;
                Console.WriteLine("If you leave me now, you'll take away the biggest part of me. Woooo Ohhh baby please don't go.");

            }

            Console.WriteLine("Just kidding. Shoo shoo I don't need you. Bye bye.");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Arthur";
            string lastname = "Morgan";
            string middlename = "Marshton";

            Console.WriteLine("Hi, my full name is " + name + " " + middlename + " " + lastname + ".");
            Console.ReadLine();

            name = name.ToUpper();

            Console.WriteLine("\"" + name + "!" + "\" Why are you shouting?");
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("\t My name is Arthur, partner. ");
            sb.Append("And here is my gang. ");
            sb.Append("We live together in harmony. ");
            sb.Append("We call ourselves the \"The Van der Linde Gang\". ");
            sb.Append("We want to live in peace but we need more money. ");
            sb.Append("As Dutch put it, \"One last time, then we go for vacation!\" ");
            sb.Append("He keeps on saying Tahiti. I do not know where the hell is Tahiti. ");
            sb.Append("Anyway, I died with tuberculosis. ");
            sb.Append("I guess that's the way it is right?");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

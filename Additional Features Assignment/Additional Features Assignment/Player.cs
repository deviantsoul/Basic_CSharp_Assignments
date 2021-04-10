using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    public class Player
    {
        //to chain the two with default of 5 = balance
        public Player(string name) : this(name, 5)
        {
        }
        public Player(string name, int firstBalance)
        {
            Balance = firstBalance;
            Name = name;
        }

        public int Balance { get; set; }
        public string Name { get; set; }

    }
}


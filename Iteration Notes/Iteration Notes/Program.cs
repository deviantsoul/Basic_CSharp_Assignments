using System;
using System.Collections.Generic;

namespace Iteration_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }

            Console.ReadLine();

            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            for (int j = 0; j < names.Length; j++)
            {
                if (names[j] == "Jesse")
                {
                    Console.WriteLine(names[j]);
                }
            }

            Console.ReadLine();

            to print everyone on the list
            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }

            Console.ReadLine();

            Set a passing score among the list made==========================
            List<int> testScores = new List<int>();
            testScores.Add(98);
            testScores.Add(99);
            testScores.Add(81);
            testScores.Add(72);
            testScores.Add(70);
            //the score can be any like i for example
            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score:" + score);
                }
            }

            Console.ReadLine();

            List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            foreach (string name in names)
            {
                if (name == "Jesse")
                {
                    Console.WriteLine(name);
                }
            }

            Console.ReadLine();

            to print all names from the list
            List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();

            To put an object to another empty list
            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            put the score to this new list
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();



        }
    }
}

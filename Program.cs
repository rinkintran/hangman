﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to play a game?");
            Console.WriteLine("How about Hangman?");
            string skelly = "      _______\n     |       |\n     0       |\n    _|_      |\n     |       |\n    / \\      |\n             |\n         ____|____\n";
            Console.WriteLine(skelly);

            Console.WriteLine("What difficulty would you like? (1-7)");
            int diff = Convert.ToInt32(Console.ReadLine());

            Dictionary d = new Dictionary();
            d.newWord(diff);
            string word = d.getWord();
            Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}


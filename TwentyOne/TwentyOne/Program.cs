﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText("C:\\Users\\Tony\\logs\\log.txt", text);

            Console.WriteLine("Welcom to the Grand Hotel and Casino. Let;s start by telling your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. would you like to join a game of 21 right now?", playerName);
            Console.ReadLine();
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.ReadLine();
        }
    }
}

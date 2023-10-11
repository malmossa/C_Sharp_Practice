using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach(Player player in players)
            {
                Console.WriteLine(player.username);
            }

            Console.ReadLine();
        }
        class Player
        {
            public string username;

            public Player(string username)
            {
                this.username = username;
            }
        }
    }
}







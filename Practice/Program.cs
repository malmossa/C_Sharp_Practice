using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoGame game1 = new VideoGame("World of Warcraft", "Blizzard", "Teen");
            VideoGame game2 = new VideoGame("League of Legends", "Riot Games", "Teen");
            VideoGame game3 = new VideoGame("Grand Theft Auto V", "Rockstar Games", "Adultts only 18");
            VideoGame game4 = new VideoGame("Minecraft", "Mojang Studios", "10+");

            Console.WriteLine(game1.name);


            Console.ReadLine();
        }

    }

    
}






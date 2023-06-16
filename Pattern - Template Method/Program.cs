using System;

namespace Pattern___Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero(3, 5);
            Adventure adventure = new ForestAdventure(hero);
            adventure.GoToAdventure();
            Console.WriteLine();

            adventure = new DungeonAdventure(hero);
            adventure.GoToAdventure();

            Console.ReadKey();
        }
    }
}

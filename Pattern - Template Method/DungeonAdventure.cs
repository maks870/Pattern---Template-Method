using System;

class DungeonAdventure : Adventure
{
    public DungeonAdventure(Hero hero) : base(hero)
    {
    }

    protected override void MeetStartEvent()
    {
        Console.WriteLine("Go to 1st floor on the dungeon");
        Enemy littleGoblin = new Enemy("Little goblin", rand.Next(0, 2), rand.Next(0, 3));
        Combat(littleGoblin);
    }
    protected override void StopForHalt()
    {
        Console.WriteLine("Hero decided to take a breath. While the hero was resting, he found a couple of coins ");
        hero.AddGold(3);
    }

    protected override void MeetMidEvent()
    {
        Console.WriteLine("Go to 2st floor on the dungeon");
        Enemy goblin1 = new Enemy("Ugly Goblin", rand.Next(1, 3), rand.Next(1, 4));
        Enemy goblin2 = new Enemy("Agile Goblin", rand.Next(2, 3), rand.Next(3, 5));
        Combat(goblin1);
        Combat(goblin2);
    }

    protected override void MeetEndEvent()
    {
        Console.WriteLine("Go to 3st floor on the dungeon");
        Console.WriteLine("Hero see 2 doors;");
        int choice = rand.Next(0, 2);

        if (choice == 0)
        {
            Console.WriteLine("Go to left door");
            Enemy troll = new Enemy("Big Troll", rand.Next(5, 8), rand.Next(0, 0));
            Combat(troll);
        }
        else if (choice == 1)
        {
            Console.WriteLine("Go to right door");
            Console.WriteLine("There is a deadly trap");
            int luck = rand.Next(0, 3);

            switch (luck)
            {
                case 0:
                    Console.WriteLine("It crushed the hero");
                    hero.onHeroDied?.Invoke();
                    break;

                case 1:
                    Console.WriteLine("It hit the hero");
                    hero.TakeDamage();
                    hero.TakeDamage();
                    break;

                case 2:
                    Console.WriteLine("Hero dodged the trap");
                    break;
            }
        }
    }

    protected override void TakeAward()
    {
        Console.WriteLine("Go to 4st floor on the dungeon");
        Console.WriteLine("There is a big room with treasures");
        Console.WriteLine("But the hero did not take a bag of gold with him");
        Console.WriteLine("So he will have to take as much as he can fit into his hero's pockets");
        int goldTreasure = rand.Next(0, 10);
        hero.AddGold(goldTreasure);
        Console.WriteLine("Get out of the Dungeon");
    }
}

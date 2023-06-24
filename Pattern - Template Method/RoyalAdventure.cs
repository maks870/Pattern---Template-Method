class RoyalAdventure : Adventure
{ 
    public RoyalAdventure(Hero hero) : base(hero)
    {
    }

    protected override void MeetStartEvent()
    {
        Console.WriteLine("Go to royal tract");
        Enemy bandit = new Enemy("Bandit", rand.Next(1, 3), rand.Next(2, 3));
        Enemy bandit = new Enemy("Bandit", rand.Next(1, 3), rand.Next(2, 3));
        Combat(bandit);
        Combat(bandit);
    }

    protected override void StopForHalt()
    {
        Console.WriteLine("Hero decided to take a breath. While the hero was resting, he found a couple of coins ");
        hero.AddGold(3);
    }

    protected override void MeetMidEvent()
    {
        Console.WriteLine("Encounter with the enchanted well");
        Console.WriteLine("The hero decides to drink from the well");
      
        int choice = rand.Next(0,2);

        if(choice == 0)
        { 
            hero.Heal();
            Console.WriteLine("Hero was healed +1HP");
        }
        else if(choice == 1)
        { 
            hero.TakeDamage();
            Console.WriteLine("Hero was poisoned -1HP");
        }
    }

    protected override void MeetEndEvent()
    {
        Console.WriteLine("Go to lonely tower");
        Console.WriteLine("Red Dragon attacks hero");

        Enemy dragon = new Enemy("Red Dragon", rand.Next(5, 8), rand.Next(0, 0));
        Combat(dragon);
    }

    protected override void TakeAward()
    {
        Console.WriteLine("You saved the princess");
        Console.WriteLine("As a reward you get her kiss");
    }


}
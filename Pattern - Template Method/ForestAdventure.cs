using System;

class ForestAdventure : Adventure
{
    public ForestAdventure(Hero hero) : base(hero)
    {
    }

    protected override void MeetStartEvent()
    {
        Console.WriteLine("Go to the forest clearing");
        Enemy butterfly = new Enemy("Beautiful Butterfly", rand.Next(0, 0), rand.Next(0, 0));
        Combat(butterfly);
        Console.WriteLine("Beautiful Butterflies don't have gold");
    }
    protected override void StopForHalt()
    {
        Console.WriteLine("Hero decided to take a breath. While the hero was resting, he found a couple of coins ");
        hero.AddGold(3);
    }

    protected override void MeetMidEvent()
    {
        Console.WriteLine("Go to the forest edge");
        Enemy butterfly = new Enemy("Very Beautiful Butterfly", rand.Next(0, 0), rand.Next(0, 0));
        Combat(butterfly);
        Console.WriteLine("Very Beautiful Butterflies don't have gold too");
    }

    protected override void MeetEndEvent()
    {
        Console.WriteLine("Go to heart of the forest");
        Enemy butterfly = new Enemy("Incredibly Beautiful Butterfly", rand.Next(0, 0), rand.Next(0, 0));
        Combat(butterfly);
        Console.WriteLine("Incredibly Beautiful Butterfly of course, also does not have gold");
    }

    protected override void TakeAward()
    {
        Console.WriteLine("The hero was given the title of 'butterfly exterminator'");
        Console.WriteLine("Get out of the forest");
    }
}

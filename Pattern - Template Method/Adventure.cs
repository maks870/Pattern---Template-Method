using System;

abstract class Adventure
{
    private bool heroIsDead = false;
    protected Hero hero;
    protected Random rand = new Random();
    private Action onStageStarted;

    protected Adventure(Hero hero)
    {
        this.hero = hero;
        this.hero.onHeroDied = null;
        this.hero.onHeroDied += EndAdventureBad;
    }

    private void SetUpCamp()
    {
        Console.WriteLine("Set up camp");
        hero.Heal();
    }

    private void EndAdventureBad()
    {
        heroIsDead = true;

        Console.WriteLine("Hero is dead");
    }

    private void EndAdventureGood()
    {
        Console.WriteLine("Hero ends adventure");
        Console.WriteLine($"Collected gold : {hero.Gold}");
    }

    protected abstract void MeetStartEvent();
    protected abstract void StopForHalt();
    protected abstract void MeetMidEvent();
    protected abstract void MeetEndEvent();
    protected abstract void TakeAward();

    protected void Combat(Enemy enemy)
    {

        int heroRand = rand.Next(0, hero.Power);
        int enemyRand = rand.Next(0, enemy.Power);

        Console.WriteLine($"Hero met the {enemy.Name}");

        if (enemyRand > heroRand)
            hero.TakeDamage();
        else if (enemyRand < heroRand)
        {
            Console.WriteLine($"{enemy.Name} is defeated");
            hero.AddGold(enemy.Gold);
        }
    }

    public void GoToAdventure()
    {
        onStageStarted += MeetStartEvent;
        onStageStarted += StopForHalt;
        onStageStarted += MeetMidEvent;
        onStageStarted += SetUpCamp;
        onStageStarted += MeetEndEvent;
        onStageStarted += TakeAward;
        onStageStarted += EndAdventureGood;

        for (int i = 0; i < onStageStarted.GetInvocationList().Length; i++)
        {
            if (heroIsDead)
                break;

            Delegate del = onStageStarted.GetInvocationList()[i];
            del?.Method.Invoke(this, null);
        }

        onStageStarted = null;
    }
}

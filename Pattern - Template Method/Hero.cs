using System;

class Hero : Character
{
    private int hp;
    public Action onHeroDied;
    public Hero(int hp, int power) : base(power, 0)
    {
        this.hp = hp;
    }

    public void Heal()
    {
        hp++;
        Console.WriteLine("Heal: +1hp");
    }

    public void TakeDamage()
    {
        hp--;
        Console.WriteLine("Take damage: -1hp");
        if (hp <= 0)
            onHeroDied?.Invoke();
    }

    public void AddGold(int gold)
    {
        this.gold += gold;
        Console.WriteLine($"Collect {gold} gold");
    }
}

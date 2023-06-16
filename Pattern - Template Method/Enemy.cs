class Enemy : Character
{
    private string name;

    public string Name => name;
    public Enemy(string name, int power, int gold) : base(power, gold)
    {
        this.name = name;
    }
}

abstract class Character
{
    protected int power;
    protected int gold;

    public int Power => power;
    public int Gold => gold;

    protected Character(int power, int gold)
    {
        this.power = power;
        this.gold = gold;
    }
}

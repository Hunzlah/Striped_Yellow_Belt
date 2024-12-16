namespace Kata_1_Level_1;

public class Warrior
{
    public Warrior(string _name, int _health)
    {
        name = _name;
        health = _health;
    }
    
    private string name;
    private int health;
    
    public string Name { get => name;}
    public int Health { get => health;}

    public Action PrimaryAction => () =>
    {
        Console.WriteLine($"{name} is standing by with health: {health}");
        Console.WriteLine($"{name} charges with a fierce attack!");
    };
    
    public void Heal(int amount) => health += amount;
}
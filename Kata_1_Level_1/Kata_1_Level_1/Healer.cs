namespace Kata_1_Level_1;

public class Healer
{
    public Healer(string _name, int _health)
    {
        name = _name;
        health = _health;
    }
    
    private string name;
    private int health;
    
    public string Name { get => name;}
    public int Health { get => health;}

    public Action<Warrior> PrimaryAction => warrior =>
    {
        Console.WriteLine($"{name} is prioritizing healing for {warrior.Name} who has the lowest health.");
        warrior.Heal(15);
        Console.WriteLine($"{name} heals {warrior.Name} for 15 health!");
        Console.WriteLine($"{warrior.Name}'s health: {warrior.Health}");
    };
}
namespace Kata_2_Level_1;

public class Character
{
    public Character(string _name, int _health, int _damage)
    {
        name = _name;
        health = _health;
        damage = _damage;
        AttackAction = Attack;
    }
    
    private string name;
    private int health;
    private int damage;
    
    public string Name { get => name; }
    public int Health { get => health; }
    public int Damage { get => damage; }

    public delegate void CharacterAction(Character target);

    public CharacterAction AttackAction;
    public event Action<string, int> OnHealthChange;

    private void Attack(Character target)
    {
        Console.WriteLine($"{name} attacks {target.name} for {damage} damage.");
        target.TakeDamage(damage);
    }

    private void TakeDamage(int amount)
    {
        health -= amount;
        OnHealthChange?.Invoke(name, health);
    }
}
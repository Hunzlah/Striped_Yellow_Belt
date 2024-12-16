namespace Kata_3_Level_1;

public class AbilityBase : IAbility
{
    public AbilityBase(string _name, string _effect)
    {
        name = _name;
        effect = _effect;
    }
    
    private string name, effect;
    public string Name { get => name;}
    public string Effect { get => effect;}
    
    public virtual void Act()
    {
        
    }
}
namespace Kata_3_Level_1;

public class AbilityContainer<T>
{
    private List<T> abilities = new List<T>();
    public void AddAbility(T ability)
    {
        abilities.Add(ability);
        Console.WriteLine($"{((AbilityBase)(object)ability).Name} (Effect: {((AbilityBase)(object)ability).Effect})");
    }

    public void RemoveAbility(T ability)
    {
        abilities.Remove(ability);
    }

    public IEnumerable<T> FetchAbilities()
    {
        return abilities;
    }
}
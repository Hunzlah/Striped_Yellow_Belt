// See https://aka.ms/new-console-template for more information

using Kata_3_Level_1;

AbilityContainer<AbilityBase> abilityContainer = new AbilityContainer<AbilityBase>();

Console.WriteLine("Adding abilities to the container...");
abilityContainer.AddAbility(new AttackAbility("Slash Attack", "Deals 15 damage"));
abilityContainer.AddAbility(new AttackAbility("Healing Light", "Restores 20 health"));

Console.WriteLine("Listing all abilities in the container: ");
foreach (AbilityBase ability in abilityContainer.FetchAbilities())
{
    Console.WriteLine($"{ability.Name} (Effect: {ability.Effect})");
}
// See https://aka.ms/new-console-template for more information

using Kata_1_Level_1;

Healer healer = new Healer("Dalia", 100);

List<Warrior> warriors = new List<Warrior>
{
    new Warrior("Bran", 100),
    new Warrior("Erin", 35)
};

Action<List<Warrior>> attackAction = warriorsList =>
{
    Console.WriteLine("Characters attacking first (health < 50):");
    foreach (var warrior in warriorsList)
    {
        if (warrior.Health < 50)
        {
            Console.WriteLine($"{warrior.Name} is attacking first due to low health!");
            warrior.PrimaryAction.Invoke();
        }
    }
    
    Console.WriteLine("Additional character actions based on role:");
    foreach (var warrior in warriorsList)
    {
        if (warrior.Health >= 50)
        {
            warrior.PrimaryAction.Invoke();
        }
    }
};

Action<List<Warrior>> healAction = warriorsList =>
{
  Warrior lowestHealthWarrior = null;
  int lowestHealth = 1000000;
  foreach (var warrior in warriorsList)
  {
      if (warrior.Health < lowestHealth)
      {
          lowestHealthWarrior = warrior;
          lowestHealth = warrior.Health;
      }
  }
  healer.PrimaryAction.Invoke(lowestHealthWarrior);
};

attackAction?.Invoke(warriors);
healAction?.Invoke(warriors);

attackAction?.Invoke(new List<Warrior>()
{
    new Warrior("Cara", 150)
});
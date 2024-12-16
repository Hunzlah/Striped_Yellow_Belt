// See https://aka.ms/new-console-template for more information

using Kata_2_Level_1;

Action<string, int> OnHealthChange = (_name, _amount) =>
{
    Console.WriteLine($"[Event] {_name}'s health changed to {_amount}.");
};

Character character1 = new Character("Arin", 50, 10);
Character character2 = new Character("Dalia", 40, 15);

character1.OnHealthChange += OnHealthChange;
character2.OnHealthChange += OnHealthChange;

character1.AttackAction(character2);
character2.AttackAction(character1);
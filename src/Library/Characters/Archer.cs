namespace Ucu.Poo.RoleplayGame;

public class Archer : ICharacter
{
    private int health = 100;
    private List<IItem> items = new List<IItem>();

    public Archer(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public int AttackValue => items.Sum(i => i.AttackValue);
    public int DefenseValue => items.Sum(i => i.DefenseValue);

    public int Health
    {
        get => health;
        private set => health = value < 0 ? 0 : value;
    }

    public void ReceiveAttack(int power)
    {
        if (DefenseValue < power)
        {
            Health -= power - DefenseValue;
        }
    }

    public void Cure()
    {
        Health = 100;
    }

    public void AddItem(IItem item)
    {
        if (!item.IsMagical)
            items.Add(item);
    }
}


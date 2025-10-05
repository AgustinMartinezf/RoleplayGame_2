namespace Ucu.Poo.RoleplayGame;

public class Wizard : ICharacter
{
    private int health = 100;
    private List<IItem> items = new List<IItem>();

    public Wizard(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public int AttackValue => items.Sum(i => i.AttackValue);
    public int DefenseValue => items.Sum(i => i.DefenseValue);

    public int Health
    {
        get => this.health;
        private set => this.health = value < 0 ? 0 : value;
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }

    public void AddItem(IItem item)
    {
        items.Add(item);
    }
}
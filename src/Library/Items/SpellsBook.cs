namespace Ucu.Poo.RoleplayGame
{
    public class SpellsBook : IItem
    {
        public List<Spell> Spells { get; set; } = new List<Spell>();

        public int AttackValue
        {
            get
            {
                int total = 0;
                if (Spells != null)
                {
                    foreach (Spell spell in Spells)
                    {
                        total += spell.AttackValue;
                    }
                }
                return total;
            }
        }

        public int DefenseValue
        {
            get
            {
                int total = 0;
                if (Spells != null)
                {
                    foreach (Spell spell in Spells)
                    {
                        total += spell.DefenseValue;
                    }
                }
                return total;
            }
        }

        public bool IsMagical
        {
            get { return true; }
        }
    }
}
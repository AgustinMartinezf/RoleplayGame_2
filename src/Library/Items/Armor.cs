namespace Ucu.Poo.RoleplayGame
{
    public class Armor : IItem
    {
        public int AttackValue
        {
            get { return 0; }
        }

        public int DefenseValue
        {
            get { return 25; }
        }

        public bool IsMagical
        {
            get { return false; }
        }
    }
}


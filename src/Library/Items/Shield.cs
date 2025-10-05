namespace Ucu.Poo.RoleplayGame
{
    public class Shield : IItem
    {
        public int AttackValue
        {
            get { return 0; }
        }

        public int DefenseValue
        {
            get { return 14; }
        }

        public bool IsMagical
        {
            get { return false; }
        }
    }
}
namespace Ucu.Poo.RoleplayGame
{
    public class Helmet : IItem
    {
        public int AttackValue
        {
            get { return 0; }
        }

        public int DefenseValue
        {
            get { return 18; }
        }

        public bool IsMagical
        {
            get { return false; }
        }
    }
}
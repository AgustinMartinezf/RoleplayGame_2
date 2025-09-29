namespace Ucu.Poo.RoleplayGame;

public class Shield : IItem
{
    public int ValorDefensa
    {
        get
        {
            return 14;
        }
    }
    public int ValorAtaque
    {
        get
        {
            return 0;
        }
    }
    public string Nombre
    {
        get
        {    
            return "Escudo";
        }
    }
}

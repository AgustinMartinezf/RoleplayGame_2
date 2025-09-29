namespace RoleplayGame_2.Library.Items;

public class Shield : IItem
{
    public int ValorDefensa
    {
        get
        {
            return 14;
        }
        set {}
    }
    public int ValorAtaque
    {
        get
        {
            return 0;
        }
        set {}
    }
    public string Nombre
    {
        get
        {    
            return "Escudo";
        }
    }
}

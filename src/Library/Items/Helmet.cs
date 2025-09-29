namespace RoleplayGame_2.Library.Items;

public class Helmet : IItem
{
    public int ValorDefensa
    {
        get
        {
            return 18;
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
            return "Casco de Hierro";
        }
    }
}

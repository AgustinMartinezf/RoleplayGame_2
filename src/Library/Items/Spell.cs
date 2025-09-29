namespace RoleplayGame_2.Library.Items;

public class Spell : IItem
{
    public int ValorAtaque
    {
        get
        {
            return 70;
        }
        set {}
    }

    public int ValorDefensa
    {
        get
        {
            return 70;
        }
        set {}
    }
    public string Nombre
    {
        get
        {    
            return "Hechizo";
        }
    }
}

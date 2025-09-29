namespace Ucu.Poo.RoleplayGame;

public class Spell : IItem
{
    public int ValorAtaque
    {
        get
        {
            return 70;
        }
    }

    public int ValorDefensa
    {
        get
        {
            return 70;
        }
    }
    public string Nombre
    {
        get
        {    
            return "Hechizo";
        }
    }
}

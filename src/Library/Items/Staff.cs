namespace Ucu.Poo.RoleplayGame;

public class Staff : IItem
{
    public int ValorAtaque 
    {
        get
        {
            return 100;
        }
        set {}
    }

    public int ValorDefensa
    {
        get
        {
            return 100;
        }
        set {}
    }
    public string Nombre
    {
        get
        {    
            return "Varita mágica";
        }
    }
}

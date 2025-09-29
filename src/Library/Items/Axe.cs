namespace Ucu.Poo.RoleplayGame;

public class Axe : IItem
{
    public int ValorAtaque 
    {
        get
        {
            return 25;
        } 
        set {}
    }
    public int ValorDefensa
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
            return "Hacha";
        }
        set {}
    }
}

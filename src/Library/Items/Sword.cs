namespace Ucu.Poo.RoleplayGame;

public class Sword : IItem
{
    public int ValorAtaque 
    {
        get
        {
            return 20;
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
            return "Espada";
        }
    }
}

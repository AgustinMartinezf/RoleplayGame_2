namespace Ucu.Poo.RoleplayGame;

public class Sword : IItem
{
    public int ValorAtaque 
    {
        get
        {
            return 20;
        } 
    }
    public int ValorDefensa
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
            return "Espada";
        }
    }
}

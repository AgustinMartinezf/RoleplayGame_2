namespace Ucu.Poo.RoleplayGame;

public class Axe : IItem
{
    public int ValorAtaque 
    {
        get
        {
            return 25;
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
            return "Hacha";
        }
    }
}

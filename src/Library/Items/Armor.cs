namespace Ucu.Poo.RoleplayGame;

public class Armor : IItem
{   
    public int ValorDefensa
    {
        get
        {
            return 25;
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
            return "Armadura";
        }
        set {}
    }
}

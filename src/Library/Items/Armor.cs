namespace Ucu.Poo.RoleplayGame;

public class Armor : IItem
{
    public int ValorDefensa
    {
        get
        {
            return 25;
        }
    }
    public int ValorAtaque
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
            return "Armadura";
        }
    }
}

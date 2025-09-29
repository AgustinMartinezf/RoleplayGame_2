namespace Ucu.Poo.RoleplayGame;

public class Bow: IItem
{
    public int ValorAtaque
    {
        get
        {
            return 15;
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
            return "Arco";
        }
    }
}

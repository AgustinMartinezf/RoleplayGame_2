namespace Ucu.Poo.RoleplayGame;

public class Helmet : IItem
{
    public int ValorDefensa
    {
        get
        {
            return 18;
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
            return "Casco de Hierro";
        }
    }
}

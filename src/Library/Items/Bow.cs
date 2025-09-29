namespace RoleplayGame_2.Library.Items;

public class Bow: IItem
{
    public int ValorAtaque
    {
        get
        {
            return 15;
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
            return "Arco";
        }
    }
}

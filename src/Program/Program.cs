using System;
using Ucu.Poo.RoleplayGame;

class Program
{
    static void Main(string[] args)
    {
        // Crear los ítems
        Staff staff = new Staff();
        Spell fireball = new Spell();
        SpellsBook book = new SpellsBook();
        book.Spells.Add(fireball);

        Axe axe = new Axe();
        Helmet helmet = new Helmet();
        Shield shield = new Shield();

        // Crear los personajes
        Wizard gandalf = new Wizard("Gandalf");
        gandalf.AddItem(staff);
        gandalf.AddItem(book);

        Dwarf gimli = new Dwarf("Gimli");
        gimli.AddItem(axe);
        gimli.AddItem(helmet);
        gimli.AddItem(shield);

        // Simulación de pelea
        Console.WriteLine($"{gimli.Name} tiene {gimli.Health}");
        Console.WriteLine($"{gandalf.Name} ataca a {gimli.Name} con {gandalf.AttackValue} de ataque");

        gimli.ReceiveAttack(gandalf.AttackValue);

        Console.WriteLine($"{gimli.Name} ahora tiene {gimli.Health}");

        gimli.Cure();

        Console.WriteLine($"{gimli.Name} se curó y tiene {gimli.Health}");
    }
}



namespace OOPAnimals;

/*En class som ärver från Kangaroo, som i sin tur har ärvt från Animal. I denna klassen så tillkommer det egenskaper
 och metoder som är unika för just Old Kangaroo. Vi sätter även defaultvärden som en Old Kangaroo ska ha.  */

public class OldKangaroo : Kangaroo
{
    private string? _oldKangarooSound;

// Constructor som tar in alla relevanta värden för denna klassen samt sätter defaults, och som har en base eftersom det är en derived class.
    public OldKangaroo(string animalType = "gammal känguru", string name = "Kang", string colour = "mörkbrun",
        int age = 34,
        bool carnivore = false, string habitat = "Sjumilaskogen",
        string whatIsInPouch = "så många saker, för många att räkna", bool tooTiredToJump = true)
        : base(animalType, name, colour, age, carnivore, habitat, whatIsInPouch)
    {
        TooTiredToJump = tooTiredToJump;
    }

    private bool TooTiredToJump { get; }

    /* En enkel metod som jämför det unika fältet i denna klass och skriver ut olika saker beroende på om det är sant
     eller falskt. Om den gamla kängurun är för trött här att hoppa så är den en bitter känguru också, men orkar den
     hoppa så är den glad. Detta är kort och gott ett annat sätt att skriva if else statement på */
    public void Complain()
    {
        var complain = TooTiredToJump
            ? "Åh vad du är jobbig kan du bara lämna mig ifred?"
            : "Vilken fin dag det är idag! Ska vi gå och lukta på blommorna?";
        Console.WriteLine($"{complain}");
    }

    /* Och på samma sätt som i metoden Complain, så jämför vi det unika fältet, och skriver ut ett passande statement
     för situationen. */
    public void PrintOldKangaroo()
    {
        var tired = TooTiredToJump
            ? "Jag är för trött för att hoppa"
            : "Kom igen nu, nu hoppar vi ikapp";
        Console.WriteLine($"{tired}");
    }

    // Här skrivs metoden MakeSound() över för at skapa en unik version för just denna klassen
    public override void MakeSound()
    {
        Console.WriteLine("Skriv in hur den gamla kängurun låter: ");
        _oldKangarooSound = Console.ReadLine();

        Console.WriteLine(_oldKangarooSound == ""
            ? "Den gamla, trötta kängurun är ganska tyst idag."
            : $"{_oldKangarooSound} låter den trötta och väldigt gamla kängurun!");
    }
}
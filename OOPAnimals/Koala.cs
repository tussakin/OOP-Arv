namespace OOPAnimals;

// En internal class, eftersom klasen behöver kommas åt av resten av programmet men inte av annat utanför programmet. 
internal class Koala : Animal

// Constructor som tar in alla relevanta värden för denna klassen samt sätter defaults, och som har en base eftersom det är en derived class.
{
    public Koala(string animalType = "koala", string colour = "grå", string name = "Steve",
        int age = 4, bool carnivore = false, string habitat = "träd", bool hasChlamydia = true,
        string koalaSound = "AAAAAAA")
        : base(animalType, colour, name, age, carnivore, habitat)
    {
        HasChlamydia = hasChlamydia;
        KoalaSound = koalaSound;
    }

    // Properties med get; set; och get; metoder. Dessa är för att hämta och sätta värden till properties
    private string? KoalaSound { get; set; }
    private bool HasChlamydia { get; }

    public override void FoodTime()
    {
        Console.WriteLine("Klockan är ju middagstid någonstans!");
    }

    public override void SleepyTime()
    {
        Console.WriteLine("Har jag varit vaken i över 20 minuter? Inte konstigt att jag är så trött. Godnatt!");
    }

    public override void BoredAnimal()
    {
        Console.WriteLine(
            "Samma träd, samma blad ,samma tråkmåns på grenen bredvid. Kan inte jag få följa med dig hem? .");
    }

    // Enkel metod som endast skriver ut ett statement 
    public void FallOutOfTree()
    {
        Console.WriteLine("Åh nej, jag tog tag i min egen arm istället för en gren och ramlade ut ur trädet igen...");
    }

    /* MakeSound metod som tar in input från användaren och skriver ut passande statements för vad den säger, beroende
     på om inputen är tom eller inte. */


    // Skriver ut ett lämpligt statement för det unika fältet i denna klass, alltså olika statements för true/false. 
    public void PrintKoala()
    {
        var chlamydia = HasChlamydia
            ? "Jag har klamydia, precis som de flesta av mina koalavänner! Whoopsie"
            : "Jag har inte klamydia, det är ganska ovanligt!";
        Console.WriteLine($"{chlamydia}");
    }

    // Här skrivs metoden MakeSound() över för at skapa en unik version för just denna klassen
    public override void MakeSound()
    {
        Console.WriteLine("Skriv in hur koalan låter: ");
        KoalaSound = Console.ReadLine();

        Console.WriteLine(KoalaSound == ""
            ? "Koalan är ganska tyst idag."
            : $"{KoalaSound} låter koalan!");
    }
}
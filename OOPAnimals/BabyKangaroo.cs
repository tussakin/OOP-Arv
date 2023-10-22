namespace OOPAnimals;

// Internal eftersom endast programmet använder sig av klassen. Defaultvärden sätts, samt unikt fält. 
internal class BabyKangaroo : Kangaroo
{
    private string? _babyKangarooSound;

    // Constructor som tar in alla relevanta värden för denna klassen samt sätter defaults, och som har en base eftersom det är en derived class. 
    public BabyKangaroo(string animalType = "Bebis känguru", string name = "Ro", string colour = "Ljusbrun",
        int age = 4,
        bool carnivore = false, string habitat = "Sjumilaskogen", string whatIsInPouch = "Små bebissaker",
        bool insidePouch = true)
        : base(animalType, name, colour, age, carnivore, habitat, whatIsInPouch)

    {
        InsidePouch = insidePouch;
    }

    private bool InsidePouch { get; }

    // Unik metod som endast skriver ut statement. 
    public void NapTime()
    {
        Console.WriteLine("Zzzzzz.... \nShh, bebisen sover.");
    }

    // Metod som skriver ut de unika delarna av klassen. Output varierar beroende på de unika fälten. Här med if else
    public void PrintBabyKangaroo()
    {
        string pouch;
        if (InsidePouch)
            pouch = "Jag chillar i morsans ficka";
        else
            pouch = "Jag är ute på äventyr utanför mammas ficka";
        Console.WriteLine($"{pouch}");
    }

    // Här skrivs metoden MakeSound() över för at skapa en unik version för just denna klassen
    public override void MakeSound()
    {
        Console.WriteLine("Skriv in hur den lilla bebiskängurun låter: ");
        _babyKangarooSound = Console.ReadLine();

        Console.WriteLine(_babyKangarooSound == ""
            ? "Den lilla bebiskängurun är ganska tyst idag."
            : $"{_babyKangarooSound} låter den lilla bebiskängurun!");
    }
}
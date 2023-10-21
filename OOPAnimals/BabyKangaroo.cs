namespace OOPAnimals;

// Internal eftersom endast programmet använder sig av klassen. Defaultvärden sätts, samt unikt fält. 
internal class BabyKangaroo : Kangaroo
{
    private string? _babyKangarooSound;

    public BabyKangaroo(string animalType, string name = "Ro", string colour = "Ljusbrun", int age = 4,
        bool carnivore = false, string habitat = "Sjumilaskogen",
        string whatIsInPouch = "Små bebissaker", bool insidePouch = true)
        : base(animalType, name, colour, age, carnivore, habitat, whatIsInPouch)

    {
        InsidePouch = insidePouch;
    }

    private bool InsidePouch { get; }

    // Unik metod som endast skriver ut statement. 
    public static void NapTime()
    {
        Console.WriteLine("Zzzzzz.... \nShh, bebisen sover.");
    }

    /* MakeSound metod som tar in input från användaren och skriver ut passande statements för vad den säger, beroende
     på om inputen är tom eller inte. */
    public void MakeSound()
    {
        Console.WriteLine("Skriv in hur den lilla bebiskängurun låter: ");
        _babyKangarooSound = Console.ReadLine();
        if (_babyKangarooSound == "")
            Console.WriteLine("Den lilla kängurun är ganska tyst idag.");
        else
            Console.WriteLine($"{_babyKangarooSound} låter bebis kängurun!");
    }

    // Metod som skriver ut de unika delarna av klassen. Output varierar beroende på de unika fälten. 
    public void PrintBabyKangaroo()
    {
        string pouch;
        if (InsidePouch)
            pouch = "Jag chillar i morsans ficka";
        else
            pouch = "Jag är ute på äventyr utanför mammas ficka";
        Console.WriteLine($"{pouch}");
    }
}
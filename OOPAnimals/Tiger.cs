namespace OOPAnimals;

// Internal class eftersom det bara behöver nås inom programmet. Defaultvärden sätts, samt deklaration av unikt fält. 
internal class Tiger : Animal
{
    private string? _tigerSound;

// Constructor som tar in alla relevanta värden för denna klassen , och som har en base eftersom det är en derived class.
    public Tiger(string animalType = "Tiger", string colour = "orange", string name = "Tony", int age = 24,
        bool carnivore = true, string habitat = "CerealBoxes", string favouriteCereal = "Kellog's frosted flakes")
        : base(animalType, colour, name, age, carnivore, habitat)
    {
        FavouriteCereal = favouriteCereal;
    }

    private string FavouriteCereal { get; }

    // Unik metod för klassen som frågar användaren efter specifik input, och svarar lämpligt efter input med hjälp av
    // en if-sats och while loop. Om användaren inte get rätt svar så kommer metoden loopas fram tills att ett rätt svar ges
    public void PourCereal()
    {
        while (true)
        {
            Console.WriteLine("Är du hungrig? Skriv 'y' för ja, 'n' för nej:");
            var hungryUser = Console.ReadLine();


            if (hungryUser == "y")
            {
                Console.WriteLine("Tigern tycker att du ser lite hungrig ut, du du får en skål flingor.");
                break;
            }

            if (hungryUser == "n")
            {
                Console.WriteLine("Du får inga flingor.");
                break;
            }

            Console.WriteLine("Du måste svara 'y' eller 'n'.");
        }
    }

    // Skriver ut det unika fältet i klassen. 
    public void PrintTiger()
    {
        Console.WriteLine($"Mina favoritflingor är {FavouriteCereal}!");
    }

    // Här skrivs metoden MakeSound() över för at skapa en unik version för just denna klassen
    public override void MakeSound()
    {
        Console.WriteLine("Skriv in hur tigern låter: ");
        _tigerSound = Console.ReadLine();

        Console.WriteLine(_tigerSound == ""
            ? "Tigern är ganska tyst idag."
            : $"{_tigerSound} låter tigern!");
    }
}
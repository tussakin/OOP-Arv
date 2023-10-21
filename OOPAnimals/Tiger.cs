namespace OOPAnimals;

// Internal class eftersom det bara behöver nås inom programmet. Defaultvärden sätts, samt deklaration av unikt fält. 
internal class Tiger : Animal
{
    public Tiger(string animalType = "Tiger", string colour = "orange", string name = "Tony", int age = 24,
        bool carnivore = true, string habitat = "CerealBoxes", string favouriteCereal = "Kellog's frosted flakes")
        : base(animalType, colour, name, age, carnivore, habitat)
    {
        FavouriteCereal = favouriteCereal;
    }

    private string FavouriteCereal { get; }

    // Unik metod för klassen som frågar användaren efter specifik input, och svarar lämpligt efter input. 
    public void PourCereal()
    {
        while (true)
        {
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

    /* MakeSound metod som tar in input från användaren och skriver ut passande statements för vad den säger, beroende
     på om inputen är tom eller inte. */
    public void MakeSound()
    {
        Console.WriteLine("Skriv in hur tigern låter:");

        var tigerSound = Console.ReadLine();

        Console.WriteLine(tigerSound == null
            ? "Tigern är ganska tyst idag."
            : $"{tigerSound} låter tigern!");
    }

    // Skriver ut det unika fältet i klassen. 
    public void PrintTiger()
    {
        Console.WriteLine($"Mina favoritflingor är {FavouriteCereal}!");
    }
}
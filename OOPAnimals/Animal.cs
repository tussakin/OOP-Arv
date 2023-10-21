namespace OOPAnimals;

/* Basklass, eller parent, till alla de andra klasserna. Den är abstract, för att det inte ska skapas bara "djur', utan
 vi vill skapa specifika djur. Vi gör fält som kommer att vara gemensamma för alla djur, så det är saker som tex. namn
 och färg, och inte saker som är specifika för vissa djur. */
public abstract class Animal
{
    protected Animal(string animalType, string colour, string name, int age, bool carnivore, string habitat)
    {
        AnimalType = animalType;
        Colour = colour;
        Name = name;
        Age = age;
        Carnivore = carnivore;
        Habitat = habitat;
    }

    //Här gör vi properties av fälten och ger de get/ get set metod(er) 
    private string AnimalType { get; }
    private string Colour { get; }

    private string Name { get; }

    private int Age { get; }

    private bool Carnivore { get; }

    private string Habitat { get; }

    // Metoder som kan nås av alla klasser, som är ett enkla statements. 
    public static void SleepyTime()
    {
        Console.WriteLine("Det är natt, time to go sleep sleep");
    }

    public static void FoodTime()
    {
        Console.WriteLine("Middagstid, yummy in my tummy!");
    }

    public static void BoredAnimal()
    {
        Console.WriteLine("Det finns ingenting att göra, now what?");
    }

    /* En metod som skriver ut alla de egenskaper som är gemensamma för alla klasser. Den skriver djurens unika värden,
     och den kollar om carnivore är true, och om så är fallet så sätter den stringen foodPreferences till köttätare.
     Annars skriver den ut vegetarian. */
    public void PrintInfo()
    {
        string foodPreferences;


        if (Carnivore)
            foodPreferences = "köttätare";

        else
            foodPreferences = "vegetarian";
        Console.Write($"Jag heter {Name} och är en {AnimalType}. Jag är {Colour} och är {Age} år gammal." +
                      $"Jag bor i {Habitat} och jag är {foodPreferences}. ");
    }
}
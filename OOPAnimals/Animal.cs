namespace OOPAnimals;

/* Basklass, eller parent, till alla de andra klasserna. Den är abstract, för att det inte ska skapas bara "djur', utan
 vi vill skapa specifika djur. Vi gör fält som kommer att vara gemensamma för alla djur. */
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
    public void SleepyTime()
    {
        Console.WriteLine($"{AnimalType} är trött nu, time to go sleep sleep");
    }

    public void FoodTime()
    {
        Console.WriteLine("Middagstiiiid, yummy in my tummy!");
    }

    public void BoredAnimal()
    {
        Console.WriteLine("Det finns ingenting att göra, now what?");
    }


    /* MakeSound metod, det är en abstrakt metod för att den ska finnas i alla klasser. En abstrakt metod får inte ha en
     body utan den sätts i de olika djurklasserna när den overrideas i klasserna. */
    public abstract void MakeSound();

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
        Console.Write($"Jag heter {Name} och är en {AnimalType}. Jag är {Colour} och är {Age} år gammal. " +
                      $"Jag bor i {Habitat} och jag är {foodPreferences}. ");
    }
}
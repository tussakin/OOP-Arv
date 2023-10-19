namespace OOPAnimals;

public class BabyKangaroo : Kangaroo
{
    private bool InsidePouch { get; set; }

    public void NapTime()
    {
      Console.WriteLine("Zzzzzz.... \nShh, bebisen sover.");  
    }

    public BabyKangaroo(string animalType, string name = "Ro", string colour ="Ljusbrun", int age = 4,
        bool carnivore = false, string habitat = "Sjumilaskogen", 
        string whatIsInPouch = "Små bebissaker", bool insidePouch = true)
        : base(animalType, name, colour, age, carnivore, habitat, whatIsInPouch)

    {
        InsidePouch = insidePouch;
    }
    public void PrintBabyKangaroo()
    {
        string pouch;
        if (InsidePouch == true)
        {
            pouch = "Jag chillar i morsans ficka";
        }
        else
        {
            pouch = "Jag är ute på äventyr utanför mammas ficka";
        }
        Console.WriteLine($"{pouch}");
    }

}
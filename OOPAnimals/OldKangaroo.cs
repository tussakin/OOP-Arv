namespace OOPAnimals;

public class OldKangaroo : Kangaroo
{
    private bool TooTiredToJump { get; set; }

    public void Complaining()
    {
        Console.WriteLine("Åh jag är så gammal och trött, får jag sova snart?");
    }
    

    public OldKangaroo (string animalType, string name = "Kang", string colour = "Dark brown", int age = 34,
        bool carnivore = false, string habitat  = "Sjumilaskogen", 
        string whatIsInPouch = "Så många saker, för många att räkna", bool tooTiredToJump = true)
        : base(animalType, name, colour, age, carnivore, habitat, whatIsInPouch)
    {
        TooTiredToJump = tooTiredToJump;
    }
    public void PrintOldKangaroo()
    {
        string tired;
        if (TooTiredToJump == true)
        {
            tired = "Jag är för trött för att hoppa";
        }
        else
        {
            tired = "Kom igen nu, nu hoppar vi ikapp";
        }
        Console.WriteLine($"{tired}");
    }
}
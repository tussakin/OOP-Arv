namespace OOPAnimals;

/* En abstrakt klass som heter Kangaroo, som är en derived class, mao så är det en klass som ärver från parent class.
 Men,det är en abstract clas vilket gör att det inte går att skapa objekt direkt från denna klass, utan för att skapa
 ett objekt med denna klassens egenskaper så behöver man gå ner på den derived class under denna. Detta är multilevel
 inheritance. Detta betyder att de klasser som ärver från Kangaroo, i detta program så är det BabyKangaroo och OldKangaroo,
 ärver från både Animal och Kangaroo. Det gör att egenskaperna i denna klass blir unika i det sätt att exakt alla klasser
 inte ärver det, men det blir inte unikt för endast en klass eftersom vi har flera klasser som ärver från denna. */
public abstract class Kangaroo : Animal
{
    public Kangaroo(string animalType, string name, string colour, int age,
        bool carnivore, string habitat, string whatIsInPouch)
        : base(animalType, colour, name, age, carnivore, habitat)
    {
        WhatIsInPouch = whatIsInPouch;
    }

    private string WhatIsInPouch { get; }


    // Metod som skriver ut statements, och ber användaren om input för att veta vad som finns inuti fickan på kängurun. 
    public void StuffInPouch()
    {
        Console.WriteLine("Hoppitihopp, jag har fler saker än Marry poppins i min ficka");
        Console.WriteLine("Skriv vad kängurun har i sin ficka:");
        var pouchThings = Console.ReadLine();
        Console.WriteLine($"Just nu har jag bland annat {pouchThings} i min ficka");
    }

    // En enkel metod som skriver ut ett statement
    public void PrintKangaroo()
    {
        Console.WriteLine($"Jag har {WhatIsInPouch} i min ficka.");
    }
}
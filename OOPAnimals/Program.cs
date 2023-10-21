namespace OOPAnimals;

// Theres Sundberg Selin, .NET23
internal class Program
{
    private static void Main(string[] args)
    {
        /* Här skapar vi objekt av de klasser vi har skapat genom att deklarera objektet, väljer den klass vi vill skapa
         objektet av och sedan tilldela värden till alla egenskaper som klasserna har. I detta program så har alla klasser
         ett par gemensamma egenskaper, och sen finns det unika egenskaper för varje klass, eftersom vi har en basklass/parent,
         och sedan klasser som ärver av den, så kallade derived classes, samt klasser som ärver av derived classes.
         Alla fält fylls och objekten skapas med dessa.  */
        var tiger1 = new Tiger("Tiger", "Orangerandig",
            "Tony", 20, true, "Kanada", "Cocopuffs");

        var koala1 = new Koala("AAAAA", "Koala", "Grå med vita fläckar",
            "Jeff", 13, false, "vart livet än tar mig mannen");

        var babyKangaroo = new BabyKangaroo("Bebiskänguru", "Olivia",
            "ljusbrun", 2, false, "Sjumilaskogen", "små saker");

        var oldKangaroo = new OldKangaroo("Gammal känguru", "kang", "Gråbrun",
            58, false, "Spanien", "Alldeles för mycket saker");

        /* Här kallas alla metoder i klasserna och körs. De kallas på olika sätt beroende på ifall metoderna är static
         eller ej. Vid static metoder så kallas metoderna med klassens namn, men vid eh static så kallas den med
         objektets namn. */
        tiger1.PrintInfo();
        tiger1.PrintTiger();
        Console.WriteLine("Är du hungrig? Skriv 'y' för ja, 'n' för nej:");
        tiger1.PourCereal();
        tiger1.MakeSound();
        Animal.FoodTime();
        Animal.SleepyTime();
        Console.WriteLine();
        koala1.PrintInfo();
        koala1.PrintKoala();
        koala1.MakeSound();
        Koala.FallOutOfTree();
        Animal.BoredAnimal();
        Console.WriteLine();
        babyKangaroo.PrintInfo();
        babyKangaroo.PrintKangaroo();
        babyKangaroo.PrintBabyKangaroo();
        babyKangaroo.StuffInPouch();
        babyKangaroo.MakeSound();
        Animal.SleepyTime();
        BabyKangaroo.NapTime();
        Console.WriteLine();
        oldKangaroo.PrintInfo();
        oldKangaroo.PrintKangaroo();
        oldKangaroo.PrintOldKangaroo();
        oldKangaroo.Complain();
        oldKangaroo.MakeSound();
        Animal.BoredAnimal();
    }
}
namespace OOPAnimals;

// Theres Sundberg Selin, .NET23
class Program
{
    static void Main(string[] args)
    {
        Tiger tiger1 = new Tiger("Tiger", "Orangerandig", 
            "Tony", 20, true, "Kanada", "Cocopuffs");
        
        Koala koala1 = new Koala("Koala", "Grå med vita fläckar", 
            "Jeff", 13, false, "vart livet än tar mig mannen", true);
        
        BabyKangaroo babyKangaroo = new BabyKangaroo("Bebiskänguru", "Olivia", 
            "ljusbrun", 2, false, "Sjumilaskogen", "små saker", true);

        OldKangaroo oldKangaroo = new OldKangaroo("Gammal känguru", "kang", "Gråbrun",
            58, false, "Spanien", "Alldeles för mycket saker", true);

        tiger1.PrintInfo();
        tiger1.PrintTiger();
        tiger1.PourCereal();
        tiger1.MakeSound();
        tiger1.FoodTime();
        tiger1.SleepyTime();
        Console.WriteLine();
        koala1.PrintInfo();
        koala1.PrintKoala();
        koala1.MakeSound();
        koala1.FallOutOfTree();
        koala1.BoredAnimal();
        Console.WriteLine();
        babyKangaroo.PrintInfo();
        babyKangaroo.PrintKangaroo();
        babyKangaroo.PrintBabyKangaroo();
        babyKangaroo.StuffInPouch();
        babyKangaroo.SleepyTime();
        babyKangaroo.NapTime();
        Console.WriteLine();
        oldKangaroo.PrintInfo();
        oldKangaroo.PrintKangaroo();
        oldKangaroo.PrintOldKangaroo();
        oldKangaroo.Complaining();
        oldKangaroo.BoredAnimal();
        
    }

}



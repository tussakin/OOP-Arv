namespace OOPAnimals;

// Theres Sundberg Selin, .NET23
internal class Program
{
    private static void Main()
    {
        /* Här skapar vi objekt av de klasser vi har skapat i en lista. En del av objekten som skapas använder sig
         av defaultvärden som är satta i klasserna, medans andra sätts här och nu. De är satta i en lista för att vi enkelt
         ska kunna loopa igenom alla djuren i nästa steg*/
        var animalList = new List<Animal>
        {
            new Tiger("tiger", "lilarandig", "Sam", 3, false, "Kanada", "cocopuffs"),

            new OldKangaroo(),

            new Koala("koala", "tie dye", "Jeff", 13,
                false, "vart livet än tar mig mannen"),


            new BabyKangaroo("bebiskänguru", "Olivia",
                "ljusbrun", 2, false, "hos morsan", "kokostoppar", false),

            new Koala(),

            new OldKangaroo("gammal känguru", "Kang", "gråbrun",
                58, false, "Spanien", "kissekatter", false),

            new Tiger(),

            new BabyKangaroo()
        };

        /* I detta steg så loopar vi igenom alla djur i hela animalList genom en foreach.  Vi tar ett djur i taget, börjar
         med att kalla på metoderna som finns i basklassen. Sedan kontrollerar vi djuret och ser vilken subklass den
         tillhör med en switch-case. När programmet hittar ett matchande djur så kallar den på de unika metoderna som
         finns i varje djurklass. I några av fallen, när djuren råkar vara kängurusar, så går den igenom den första
         switchen och hittar kangaroo, kallar på metoderna som ligger under den klassen, och sen går den in i den inre
         switch caset för att kalla på de unika metoderna som finns i baby och old kangaroo. Efter att de unika metoderna
         körts så går den ut ur switch caset, går igenom resten av de gemensamma metoderna i animal klassen. När djuret
        är klart så går den vidare till nästa djur och gör samma process tills listan är genomloopad. */
        foreach (var animal in animalList)
        {
            animal.PrintInfo();

            switch (animal)
            {
                case Tiger tiger:
                    tiger.PrintTiger();
                    tiger.PourCereal();
                    break;
                case Koala koala:
                    koala.PrintKoala();
                    koala.FallOutOfTree();
                    break;
                case Kangaroo kangaroo:
                    kangaroo.PrintKangaroo();
                    switch (kangaroo)
                    {
                        case BabyKangaroo babyKangaroo:
                            babyKangaroo.PrintBabyKangaroo();
                            babyKangaroo.StuffInPouch();
                            break;
                        case OldKangaroo oldKangaroo:
                            oldKangaroo.Complain();
                            oldKangaroo.StuffInPouch();
                            break;
                    }

                    break;
            }

            animal.BoredAnimal();
            animal.MakeSound();
            animal.FoodTime();
            animal.SleepyTime();
            Console.WriteLine();
        }
    }
}
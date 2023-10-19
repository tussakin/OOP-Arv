using System;
namespace OOPAnimals
{
    public abstract class Animal
    {
        private string AnimalType { get; }
        private string Colour { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool Carnivore { get; }

        public string Habitat { get; }

        public void SleepyTime()
        {
            Console.WriteLine("Det är natt, time to go sleep sleep");
        }

        public void FoodTime()
        {
            Console.WriteLine("Middagstid, yummy in my tummy");
        }

        public void BoredAnimal()
        {
            Console.WriteLine("Det finns ingenting att göra, now what?");
        }

        public Animal(string animalType, string colour, string name, int age, bool carnivore, string habitat)
        {
            AnimalType = animalType;
            Colour = colour;
            Name = name;
            Age = age;
            Carnivore = carnivore;
            Habitat = habitat;

        }

        public void PrintInfo()
        {
            
         string foodPreferences;


            if (Carnivore == true)
        {

            foodPreferences = "Köttätare";
        }

        else
        {
            foodPreferences = "vegetarian";

        }
        Console.Write($"Jag heter {Name} och är en {AnimalType}. Jag är {Colour} och är {Age} år gammal." +
        $"Jag bor i {Habitat} och jag är {foodPreferences}. ");
        }}




}

using System;
namespace OOPAnimals
{
  class Tiger : Animal
    {
        private string FavouriteCereal { get; set; }


        public Tiger(string animalType = "Tiger", string colour="orange", string name="Tony", int age=24, 
            bool carnivore=true, string habitat="CerealBoxes", string favouriteCereal="Kellogs frosted flakes")
            : base(animalType, colour, name, age, carnivore, habitat)
        {
            
            FavouriteCereal = favouriteCereal;
        }

        
        public void PourCereal()
        {
            Console.WriteLine("Tigern tycker att du ser lite hungrig ut, du du får en skål flingor.");
        }
        
        public void MakeSound()
        {
            Console.WriteLine("Grrrreat säger tigern!");
            
            
        }
        
        public void PrintTiger()
        {
            Console.WriteLine($"Mina favoritflingor är {FavouriteCereal}!");
        }
    }
}





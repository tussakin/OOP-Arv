using System;
using System.Drawing;
using System.Xml.Linq;

namespace OOPAnimals
{
     public abstract class Kangaroo : Animal
    { 
        private string WhatIsInPouch{ get; set;}

        public void StuffInPouch()
        {            
            Console.WriteLine("Hoppitihopp, jag har fler saker än Marry poppins i min ficka");
            Console.WriteLine();
            Console.WriteLine("Skriv vad kängurun har i sin ficka:");
            string pouchThings = Console.ReadLine();
            Console.WriteLine($"Just nu har jag bland annat {pouchThings} i min ficka");
        }
        
        public void MakeSound()
        {
            Console.WriteLine("Boink boink låter Kängurun");
        }

        public Kangaroo(string animalType,string name, string colour, int age,
            bool carnivore, string habitat, string whatIsInPouch)
            : base(animalType, colour, name, age, carnivore, habitat)
        {
            WhatIsInPouch = whatIsInPouch;
        }
        public void PrintKangaroo()
        {
            Console.WriteLine($"Jag har {WhatIsInPouch} i min ficka.");
        }
    }
}

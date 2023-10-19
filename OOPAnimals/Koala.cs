using System;
using System.Drawing;
using System.Xml.Linq;

namespace OOPAnimals
{
    class Koala : Animal

    {
        private bool HasChlamydia
        {
            get; set;
        }
        public Koala(string animalType = "Koala", string colour="Grey", string name="Steve", int age=4, 
            bool carnivore=false, string habitat="trees", bool hasChlamydia=true)
            : base(animalType, colour, name, age, carnivore, habitat)
        {
            HasChlamydia = hasChlamydia;
        }

        public void FallOutOfTree()
        {
            Console.WriteLine("Åh nej, jag tog tag i min egen arm istället för en gren och ramlade ut ur trädet igen...");
        }
        
    public void MakeSound()
        {
            Console.WriteLine("AAAAAHH  låter koalan");
        }
    public void PrintKoala()
    {
        string chlamydia;
        if (HasChlamydia == true)
        {
            chlamydia = "Jag har klamydia, precis som de flesta av mina koalavänner! Whoopsie";
        }
        else
        {
            chlamydia = "Jag har inte klamydia, det är ganska ovanligt!";

        }
        Console.WriteLine($"{chlamydia}");
    }
    }
}



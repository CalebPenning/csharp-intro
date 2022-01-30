using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {   
        // Doing some genetic modification
        static void MultipleLegs(PetStruct petStruct, Pet petClass)
        {
            petStruct.Legs = petStruct.Legs * 2;
            petClass.Legs = petClass.Legs * 2;

            Console.WriteLine($"Internal Method - A {petStruct.Type} has {petStruct.Legs} legs.");
            Console.WriteLine($"Interal Method - A {petClass.Type} has {petClass.Legs} legs.");
            Console.ReadLine(); 
        }

        static void Main(string[] args)
        {
            PetStruct dog;
            dog.Type = PetType.Dog;
            dog.HasFur = true;
            dog.Legs = 4;
            dog.Name = "Honey";

            var duck = new Pet();
            duck.Type = PetType.Duck;
            duck.HasFur = false;
            duck.Legs = 2;
            duck.Name = "Quackity";

            Console.WriteLine($"Hello! I'm {dog.Name} the {dog.Type}! I have {dog.Legs} legs and if you're wondering if I have fur, it's {dog.HasFur}");
            Console.WriteLine($"Hello! I'm {duck.Name} the {duck.Type}! I have {duck.Legs} legs and if you're wondering if I have fur, it's {duck.HasFur}");
            Console.ReadLine();

            MultipleLegs(dog, duck);
        }
    }

    class Pet
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }

    struct PetStruct
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }

    enum PetType
    {
        Dog,
        Duck
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
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

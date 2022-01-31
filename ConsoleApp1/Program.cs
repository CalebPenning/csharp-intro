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
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Yoooooo");
            listOfStrings.Insert(1, "yeeeeeeeee");

            listOfStrings.Remove("Yoooooo");
            listOfStrings.RemoveAt(0);

            Dictionary<string, List<int>> scores = new Dictionary<string, List<int>>();
            scores.Add("Caleb", new List<int>());
            scores["Caleb"].Add(24);
            scores["Caleb"].Add(25);
            scores["Caleb"].Add(21);

            for (int a = 0; a < scores["Caleb"].Count; a++)
            {
                Console.WriteLine($"{scores["Caleb"][a]}");
            }

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

            Console.WriteLine($"Hello! I'm {dog.Name} the {dog.Type}! I have {dog.Legs} legs and if you're wondering if I have fur, it's {dog.HasFur}");
            Console.WriteLine($"Hello! I'm {duck.Name} the {duck.Type}! I have {duck.Legs} legs and if you're wondering if I have fur, it's {duck.HasFur}");
            Console.ReadLine();


            List<Pet> pets = new List<Pet>();
            pets.Add(new Pet { HasFur = false, Legs = 4, Name = "Jasper's Friend", Type = PetType.Lizard });
            pets.Add(new Pet { HasFur = true, Legs = 4, Name = "Honey Bear", Type = PetType.Cat });
            pets.Add(new Pet { HasFur = true, Legs = 4, Name = "Owen", Type = PetType.Cat });

            List<Pet> results = (from p in pets
                                where p.Type == PetType.Lizard
                                select p).ToList();

            results = pets.Where(p => p.Type == PetType.Cat | p.Type == PetType.Lizard).ToList();

            for (int j = 0; j < results.Count; j++)
            {
                Console.WriteLine(results[j].Name);
            }
            int answer = int.Parse(Console.ReadLine());
            int i = 0;
            while (i <= answer)
            {
                if (i < answer)
                {
                    Console.WriteLine($"{i} isn't the right answer, try again");
                }

                else
                {
                    Console.WriteLine($"That's right! {i} is the rigth answer!");
                }

                i++;
            }

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
        Cat,
        Duck,
        Lizard
    }
}

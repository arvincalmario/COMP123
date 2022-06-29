using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_homework02_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet p1 = new Pet("Courage", "cowardly dog", 4);
            Pet p2 = new Pet("Scrappycoco", "silkysmooth", 5);
            Pet p3 = new Pet("Muning", "grumpy cat", 9);
            Pet p4 = new Pet("Max", "good boy", 12);

            List<Pet> petList = new List<Pet>() { p1, p2, p3, p4 };

            p1.SetOwner("Arvin");
            p2.SetOwner("Arvin");
            p3.SetOwner("Cadiente");
            p4.SetOwner("Almario");

            p1.Train();
            p4.Train();

            Console.WriteLine("List\n");
            foreach (Pet petList1 in petList)
            {
                Console.WriteLine(petList1);
            }
            Console.Write("*******************************************************\n");
            Console.Write("Enter Owners name: ");
            string owner = Console.ReadLine();
            foreach (Pet petList1 in petList)
            {
                if (petList1.Owner == "Arvin")
                {
                    Console.WriteLine(petList1);
                }
            }
        }
    }
    class Pet
    {
        public string Name { get; }
        public int Age { get; }
        public string Description { get; }
        public string Owner { get; private set; }
        public bool IsHouseTrained { get; private set; }

        public Pet(string name, string description, int age=1)
        {
            Name = name;
            Description = description;
            Age = age;
        }
        public override string ToString()
        {
            string trained = (IsHouseTrained == true) ? "Yes, Pet is trained" : "No, Pet is untrained";
            return $"Pet Name: {Name} \nAge: {Age} \nDescription: {Description} \nPet Trained?: {IsHouseTrained} \nOwner Name: {Owner}\n";
        }
        public void Train()
        {
            IsHouseTrained = true;
        }
        public void SetOwner(string newOwner)
        {
            Owner = newOwner;
        }
    }
}

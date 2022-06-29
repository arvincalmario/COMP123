using System.Text.Json; 

namespace homework04_lizards
{
    class Program
    {
        enum LizardColor
        {
            Black,
            Blue,
            Brown,
            Green,
            Yellow,
            Gray,
            Red,
            White,
            Pink
        }
        public static void Main(string[] args)
        {
            //Console.WriteLine("hello world");
            Lizard.TestHarness();
        }
        class Lizard
        {
            public string Species { get; set; }
            public int Quantity { get; set; }
            public bool IsDangerous { get; set; }
            public LizardColor Color { get; set; }
            public Lizard()
            {

            }
            public override string ToString()
            {
                return $"Species: {Species}\nQuantity: {Quantity}\nIs Dangerous?: {IsDangerous}\nColor:{Color}\n\n---";
            }
            static List<Lizard> CreateLizards()
            {
                return new List<Lizard>()
            {
                new Lizard() { Species = "Crested gecko", Quantity = 4, IsDangerous = false, Color = LizardColor.Yellow | LizardColor.White },
                new Lizard() { Species = "Spider-man agama", Quantity = 3, IsDangerous = false, Color = LizardColor.Blue | LizardColor.Red},
                new Lizard() { Species = "Leopard gecko", Quantity = 3, IsDangerous = true, Color = LizardColor.Yellow |LizardColor.Black },
                new Lizard() { Species = "Palmato gecko", Quantity = 4, IsDangerous = false, Color = LizardColor.Pink },
                new Lizard() { Species = "Bearded dragon", Quantity = 1, IsDangerous = true, Color = LizardColor.Yellow },
                new Lizard() { Species = "Crested gecko", Quantity = 4, IsDangerous = false, Color = LizardColor.Black },
                new Lizard() { Species = "Argentine tegu", Quantity = 4, IsDangerous = true, Color = LizardColor.Black },
                new Lizard() { Species = "Green Thorny-tailed iguana", Quantity = 4, IsDangerous = true, Color=LizardColor.Green| LizardColor.Black |LizardColor.Blue},
                new Lizard() { Species = "Thorny devil", Quantity = 4, IsDangerous = true, Color=LizardColor.Red },
                new Lizard() { Species = "Casquehead lizard", Quantity = 4, IsDangerous = true, Color = LizardColor.Red },
                new Lizard() { Species = "Emerald tree monitor", Quantity = 4, IsDangerous = false, Color = LizardColor.Green},
                new Lizard() { Species = "Panther chameleon", Quantity = 6, IsDangerous = false, Color = LizardColor.Green },
                new Lizard() { Species = "Veiled chameleon", Quantity = 4, IsDangerous = true, Color = LizardColor.Green },
                new Lizard() { Species = "Water monitor", Quantity = 4, IsDangerous = false , Color = LizardColor.Black},
                new Lizard() { Species = "Komodo dragon", Quantity = 4, IsDangerous = true, Color = LizardColor.Gray },
                new Lizard() { Species = "Green iguana", Quantity = 4, IsDangerous = false, Color = LizardColor.Green },
                new Lizard() { Species = "Blotched blue-tongue lizard", Quantity = 4, IsDangerous = true, Color=LizardColor.Black },
                new Lizard() { Species = "Gila monster", Quantity = 4, IsDangerous = true, Color = LizardColor.Black }
            };
            }
            public static void TestHarness()
            {
                List<Lizard> lizards = Lizard.CreateLizards();

                Console.WriteLine($"Serializing one lizard");
                string filename = "one_lizard.json";
                //code to serialize the first lizard in the collection
                //to get the first lizard use lizards[0]

                //File.WriteAllText(filename, JsonSerializer.Serialize(lizards[0]));

                Console.WriteLine($"De-serializing one lizard");
                //code to de-serialize the contents of the above file and display the resulting object

                Lizard lizard1 = JsonSerializer.Deserialize<Lizard>(File.ReadAllText(filename));
                Console.WriteLine(lizard1);

                Console.WriteLine($"Serializing all lizards");
                filename = "all_lizards.json";
                //code to serialize the entire collection of lizards

                //File.WriteAllText(filename, JsonSerializer.Serialize(lizards));

                Console.WriteLine($"De-serializing all lizards");
                //code to de-serialize the contents of the above file and display the resulting objects

                List<Lizard> lizard2 = JsonSerializer.Deserialize<List<Lizard>>(File.ReadAllText(filename));
                foreach (Lizard l in lizard2)
                    Console.WriteLine(l);

            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCreator();
            Console.ReadKey();
        }

        static void PlayerCreator()
        {
            Console.Write("Dragons\n" +
                "Once upon a time, in the depths of the mountains of a distant country, the first dragon was born.\n"
                + "His name was...\n" +
                "Enter your dragon's name: ");
            Player player = new Player();
            player.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"His name was {player.name}.\n" +
                "Although he was still small and outwardly resembled rather a large snake,\n the makings of talent were already observed in him.\n");

            while (true)
            {
                Console.Clear();

                bool success = false;

                Console.WriteLine($"How do you determine {player.name}'s talents?\n" +
                "Option 1: Random\n" +
                "You generate six attribute values ​​randomly.\n" +
                "Option 2: Set\n" +
                "You can use the following numbers: 15, 14, 13, 12, 10, 8.\n" +
                "Assign each of the characteristics one number from the set.\n" +
                "Option 3: Manually\n" +
                "You get 27 points, which you distribute between the values of the characteristics.\n" +
                "The characteristic value cannot be lower than 8.\n" +
                "The characteristic value cannot be higher than 15.\n" +
                "Please write the number of the selected option.\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        player.RandomCharGen();
                        success = true;
                        player.ShowCharacteriscs();
                        break;
                    case "Random":
                        player.RandomCharGen();
                        success = true;
                        player.ShowCharacteriscs();
                        break;
                    case "2":
                        player.SetCharGen();
                        success = true;
                        player.ShowCharacteriscs();
                        break;
                    case "Set":
                        player.SetCharGen();
                        success = true;
                        player.ShowCharacteriscs();
                        break;
                    case "3":
                        break;
                    case "Manually":
                        break;
                }

                if(success == true)
                {
                    Console.WriteLine("Does your choice suit you? y/n");
                    if (Console.ReadLine() == "y") break;
                    else player.ResetStats();
                }
            }
        }
    }
}

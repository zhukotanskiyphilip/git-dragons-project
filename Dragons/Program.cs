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
            Start();
        }

        static void Start()
        {
            Console.Write("Dragons\n" +
                "Once upon a time, in the depths of the mountains of a distant country, the first dragon was born.\n"
                + "His name was...\n" +
                "Enter your dragon's name: ");
            Console.ReadLine();
        }
    }
}

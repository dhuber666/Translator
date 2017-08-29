using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            do
            {
                Console.Write("Gib einen Text ein den du gerne in's Englische übersetzen möchtest, Q zum Beenden: ");
                input = Console.ReadLine();
                if (input.ToUpper() == "Q")
                    break;
                Console.WriteLine(Translator.Translate(input));

            } while (input.ToUpper() != "Q");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;

            // loop will run once
            do
            {
                Console.WriteLine("Please enter the option - F for File or M for Manual");
                var option = Console.ReadLine() ?? string.Empty; // Null-coalescing assignment if user input is nothing

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name: ");
                        ExecuteScrambledWordsInFileScenerio();
                        break;
                    case "M":
                        Console.Write("Enter scrambled words manually: ");
                        ExecuteScrambledWordsManualEntryScenerio();
                        break;
                    default:
                        Console.Write("Option was not recognized.");
                        break;
                }

                var continueDecision = string.Empty;
                do // keep running this loop until 'Y' or 'N' is entered, at the initial execution this "do while statement" evaluates to "true"
                {
                    Console.WriteLine("Do you want to continue? Y/N");
                    continueDecision = (Console.ReadLine() ?? string.Empty); // Null-coalescing assignment

                } while (
                !continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && !continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordUnscramble = continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

        private static void ExecuteScrambledWordsManualEntryScenerio()
        {            
        }

        private static void ExecuteScrambledWordsInFileScenerio()
        {            
        }
    }
}

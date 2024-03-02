using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoxAutomotive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentenceParser = new SentenceParser();
            if(args.Length > 0)
            {
                for(int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("Input " + (i + 1) + ": " + args[i]);
                    Console.WriteLine("Output " + (i + 1) + ": " + sentenceParser.ParseSentence(args[i]));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("What is your input?");
                Console.Out.Flush();
                var input = Console.ReadLine();
                Console.WriteLine("Output: " + sentenceParser.ParseSentence(input));
                Console.WriteLine();

                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace WordFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> matrix = new List<string>
            {
                "abcdc", "fgwlo", "chill", "pqnsd", "uvdxy"
            };           

            List<string> wordstream = new List<string>
            {
                "cold", "wind", "snow", "chill"
            };

            var wordFinder = new WordFinder(matrix);
            var results = wordFinder.Find(wordstream);

            Console.WriteLine("Top 10 list");
            foreach (var result in results) 
            { 
                Console.WriteLine(result);
            }                
        }
    }        
}

using System.Collections.Generic;
using System.Linq;

namespace WordFinder
{
    public class WordFinder : IWordFinder
    {
        private readonly IEnumerable<string> matrix;
        private readonly IEnumerable<string> transposeMatrix = Enumerable.Empty<string>();

        public WordFinder(IEnumerable<string> matrix) 
        { 
            this.matrix = matrix;
            this.TransposeMatrix(matrix);
        }

        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            var finalResults = new List<WordCounter>();
            var min = 0;        

            foreach (string word in wordstream) 
            {
                // We check if the word has already been added to the top 10 list to avoid counting it more than once.
                if (!finalResults.Any(w => w.Word.Equals(word)))
                {
                    var ocurrences = this.SearchHorizontally(word) + this.SearchVertically(word);

                    // If there are no occurrences we don't have to do something with that word.
                    if (ocurrences > 0)
                    {
                        // If there are 10 items in the top 10 list, we need to check if the new word has more ocurrences that the word
                        // with the minimum of occurrences. Otherwise, we just add the new word to the top 10 list.
                        if (finalResults.Count() >= 10)
                        {
                            min = finalResults.Min(r => r.Ocurrences);
                            if (ocurrences > min)
                            {
                                finalResults.Remove(finalResults.FirstOrDefault(r => r.Ocurrences == min));
                                finalResults.Add(new WordCounter(word, ocurrences));
                            }
                        }
                        else
                        {
                            finalResults.Add(new WordCounter(word, ocurrences));
                        }
                    }
                }                
            }

            return finalResults.Any() ? finalResults.Select(w => w.Word) : Enumerable.Empty<string>();
        }     

        /// <summary>
        /// Returns the occurrences for a word that was found horizontally.
        /// </summary>
        /// <param name="word">The word to seach inside the original matrix</param>
        /// <returns></returns>
        private int SearchHorizontally(string word)
        {            
            return matrix.Where(m => m.Contains(word)).Count();
        }

        /// <summary>
        /// Returns the occurrences for a word that was found vertically.
        /// </summary>
        /// <param name="word">The word to search inside the transponse matrix</param>
        /// <returns></returns>
        private int SearchVertically(string word)
        {
            return transposeMatrix.Where(m => m.Contains(word)).Count();
        }

        /// <summary>
        /// Returns the transponse matrix.
        /// Since the original matrix could be 64x64 it is not too big, so the compute operation to transpose the matrix is not expensive. In this way,
        /// we will able to search words that are vertically from the original matrix in horizontal way from the transponse matrix.
        /// </summary>
        /// <param name="matrix">The original matrix</param>
        private void TransposeMatrix(IEnumerable<string> matrix)
        {            
            var rowLength = matrix.FirstOrDefault().Length;

            for (var i = 0; i < rowLength; i++)
            {
                transposeMatrix.Append(string.Join("", matrix.Select(row => row[i])));
            }
        }

        /// <summary>
        /// This class aims to summarize the occurrences of each word so that the top 10 can be kept in a list.
        /// </summary>
        public class WordCounter
        {
            public string Word { get; }
            public int Ocurrences { get; }

            public WordCounter(string word, int ocurrences)
            {
                Word = word;
                Ocurrences = ocurrences;
            }
        }
    }
}

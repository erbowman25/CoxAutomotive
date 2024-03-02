using System.Collections.Generic;

namespace CoxAutomotive
{
    internal class SentenceParser
    {
        public string ParseSentence(string sentence)
        {
            var sentenceCharArray = sentence.ToCharArray();
            var delimiters = new List<int> { -1 };

            // Locate all delimiters
            for (var i = 0; i < sentenceCharArray.Length; i++)
            {
                if (!char.IsLetter(sentenceCharArray[i]))
                {
                    delimiters.Add(i);
                }
            }

            // Add the end of the sentence to list of delimiters
            delimiters.Add(sentenceCharArray.Length);

            var result = "";

            for (var i = 1; i < delimiters.Count; i++)
            {
                var startIndex = delimiters[i - 1] + 1;
                var wordLength = delimiters[i] - startIndex;
                var tempWord = sentence.Substring(startIndex, wordLength);
                result += ParseWord(tempWord);

                // Add delimters to the result, excluding the end of sentence
                if(delimiters[i] < sentenceCharArray.Length) result += sentenceCharArray[delimiters[i]];
            }

            return result;

        }

        private string ParseWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word) || word.Length == 1) return word;

            var wordCharArray = word.ToCharArray();

            var firstLetter = wordCharArray[0];
            var middleNumber = wordCharArray.Length - 2;
            var lastLetter = wordCharArray[wordCharArray.Length - 1];

            return firstLetter + middleNumber.ToString() + lastLetter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            List<string> matchList = new List<string>();

            foreach (var word in dictionary)
            {
                if (jumble.Count() == word.Count())
                {
                    var compareStrings = CompareStrings(word, jumble);
                    if (compareStrings)
                        matchList.Add(word);
                }
            }

            return matchList.ToArray();
        }

        public bool CompareStrings(string word, string jumble)
        {
            var jumbleAplha = jumble.OrderBy(x => x);
            var wordAlpha = word.OrderBy(x => x);

            return jumbleAplha.SequenceEqual(wordAlpha);
        }

    }

    public static class Program
    {
        public static void  Main(string[] args)
        {
            var actualResult = new Solution().GetPossibleWords("ainstuomn", new[] { "mountains", "hills", "mesa" });

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiscalCodeLib.Utils
{
    public class VowelsConsonantsSplitter
    {
        public VowelsConsonantsSplitter(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                throw new ArgumentException("Parameter str can't be null, whitespace or empty");
            Vowels = new List<char>();
            Consonants = new List<char>();
            Split(str);
        }


        public List<char> Vowels { get; }
        public List<char> Consonants { get; }

        private void Split(string str)
        {
            foreach (var letter in str)
                if (CommonDataStructures.Vowels.Contains(letter))
                    Vowels.Add(letter);
                else
                    Consonants.Add(letter);
        }
    }
}
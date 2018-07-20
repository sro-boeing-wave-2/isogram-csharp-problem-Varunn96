using System;
using System.Collections.Generic;
using System.Linq;

namespace isogram
{
    public class IsogramClass
    {
        public static bool isIsogram(string input)
        {
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i += 1)
            {
                if (input[i] >= 97 && input[i] <= 122)
                {
                    if (charDictionary.ContainsKey(input[i])) return false;
                    else charDictionary.Add(input[i], i);
                }
            }
            return true;   
        }
    }
}

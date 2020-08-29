using System;
using System.Collections.Generic;

namespace BigO.Classes
{
    public class RepetitionChecker
    {
        public bool CheckRepeated(char[] array)
        {
            var dictionary = new HashSet<char>();
            foreach(var c in array)
            {
                if(dictionary.TryGetValue(c, out var value))
                {
                    Console.WriteLine($"Repeated: {c}");
                    return true;
                }
                dictionary.Add(c);
            }
            return false;
        }
        public bool CheckRepeatedBruteForce(char[] array)
        {
            for(int i = 0; i<array.Length-1; i++)
            {
                for(int j = i+1; j <array.Length;j++)
                {
                    if(array[i]==array[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
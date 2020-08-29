using System;
using System.Collections.Generic;
using BigO.Classes;

namespace BigO
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new char[] {'a','b','c','r','w','w'};
            var repetitionChecker = new RepetitionChecker();

            var hasRepetitionBruteForce = repetitionChecker.CheckRepeatedBruteForce(array);
            Console.WriteLine(hasRepetitionBruteForce ? "Repeated chars" : "No repetitions");

            var hasRepetition = repetitionChecker.CheckRepeated(array);
            Console.WriteLine(hasRepetition ? "Repeated chars" : "No repetitions");
        }
    }
}

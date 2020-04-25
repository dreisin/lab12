using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FileW;

namespace CounterOp
{
    public static class Counter
    {
        public static void DictCounter()
        {
            Dictionary<string, int> wordsDict = FileW.FileWork.ParseFile();

            var maxElem = wordsDict.Aggregate((x, y) => x.Value > y.Value ? x : y);
            Console.WriteLine("Most repeated: ");
            foreach (KeyValuePair<string, int> kvp in wordsDict.Where(f => (f.Value == maxElem.Value)))
            {
                Console.WriteLine(kvp.Key);
            }
        }

        public static string DictSearch(string yourWord, Dictionary<string, int> wordsDict)
        {
            if (!wordsDict.ContainsKey(yourWord))
            {
                Console.WriteLine("Not found");
            }
            else
            {
                foreach (KeyValuePair<string, int> kvp in wordsDict.Where(f => (f.Key == yourWord)))
                {
                    Console.WriteLine(kvp.Key.Length + " symbols in the word " + yourWord);
                    Console.WriteLine("The " + yourWord + " repeated " + kvp.Value + " times");
                }
            }
            return "";
        }
    }
}
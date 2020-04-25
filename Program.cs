using System;
using FileW;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
          // Console.Write("Enter the name of the dictionary you need: ");
          //  var fileName = Console.ReadLine();
          //  Console.WriteLine("Dictionary is " + fileName);
            Console.WriteLine("Dictionary: ");
            foreach (var keyValue in FileWork.ParseFile())
            {
                Console.WriteLine(keyValue.Key + " : " + keyValue.Value);

            }

            CounterOp.Counter.DictCounter();
            Console.Write("Enter the word for information about it's repeats: ");
            var yourWord = Console.ReadLine();
            CounterOp.Counter.DictSearch(yourWord, FileWork.ParseFile());
        }
    }
}
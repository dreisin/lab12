﻿using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;

namespace FileW
{
    static class FileWork
    {
        public static Dictionary<string, int> ParseFile()
        {
            Dictionary<string, int> wordsDict = new Dictionary<string, int>();
            var pathPart = @"C:\C#\LABA12new\LABA12new\file.txt";
            try
            {
                using (StreamReader sr = new StreamReader(pathPart))
                {
                    while (!sr.EndOfStream)
                    {
                        string strFromFile = sr.ReadLine();
                        string[] wordsArr = strFromFile.Replace(',', ' ').Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < wordsArr.Length; i++)
                        {
                            if (!wordsDict.ContainsKey(wordsArr[i]))
                            {
                                wordsDict.Add(wordsArr[i], 1);
                            }
                            else wordsDict[wordsArr[i]]++;
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            if (wordsDict.Count == 0)
            {
                Console.WriteLine("Empty dictionary");
                Environment.Exit(1);
            }
            return wordsDict;
        }
    }
}
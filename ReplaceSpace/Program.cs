using System;
using System.Collections;
using System.Collections.Generic;

namespace ReplaceSpace
{
    class Program
    {
        /// <summary>
        /// Solution to Cracking the Coding interview string replacement problem
        /// Only diversion is the forwards iteration where the occurence of two
        /// consecutive spaces are used to signal the end of the string.
        ///
        ///  Assumption made is that m spaces in S are at most of sizeOf(char) in length 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var sentence = "There are things in this would we may never understand                      ";
            var result = new char[sentence.Length];
            var subtractChars = 0;
            for(var i = 0; i < sentence.Length;i++)
            {
                if (sentence[i] == ' ')
                {
                    if (sentence[i + 1] == ' ')
                        break;
                    result[i + subtractChars] = '%';
                    result[i + subtractChars + 1] = '2';
                    result[i + subtractChars + 2] = '0';
                    subtractChars += 2;
                   continue;
                }
                result[i + subtractChars] = sentence[i];
            }
            Console.WriteLine(result.ToString());
        }
    }
}

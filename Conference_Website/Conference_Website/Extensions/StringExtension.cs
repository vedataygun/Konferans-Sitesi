using System;
using System.Collections.Generic;
using System.Linq;

namespace Conference_Website.Extensions
{
    public static class StringExtension
    {
        public static string CapitalFirstLetterInWord(this string value)
        {
            var wordList = value.Split(' ');
            var newWordList = new List<string>();

            foreach ( var word in wordList )
            {
                string newWord = word[0].ToString().ToUpper();
                newWord += word.Substring(1);
                newWordList.Add(newWord);
            }

            

            return string.Join(" ",newWordList);
        }
    }
}

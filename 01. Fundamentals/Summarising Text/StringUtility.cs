using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarising_Text
{
    public class StringUtility
    {
       public static string SummerizeText(string sentence)
        {
            string summary = null;
            const int maxLength = 20;
            if (sentence.Length < maxLength)
            {
                return sentence;
            }
            else
            {
                sentence.Substring(0, maxLength);
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var symmaryWords = new List<string>();
                foreach (var word in words)
                {
                    symmaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                }
                summary = String.Join(" ", symmaryWords) + "...";
            }
            return summary;
        }
    }
}

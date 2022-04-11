using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01.Strings
{
    internal class Program
    {
        static void Main()
        {
            string s = "Welcome to Programming";
            #region count words
            var words = s.Split(' ');
            Console.WriteLine("The total number of word is {0}", words.Length);
            #endregion
            #region Count Vowels&consonants
            string vo = "aouei";
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < vo.Length; j++)
                {
                    if (s[i] == vo[j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine("The total number of vowels {0}", counter);
            Console.WriteLine("The total number of consonants {0}", s.Length - counter);
            #endregion
            #region Replace with commas
            Console.WriteLine("string replaced by commas {0}", s.Replace(' ', ','));
            #endregion
            #region Replace lower with upper
            Console.WriteLine("string replace lower by upper {0}", s.ToUpper());
            #endregion
            Console.ReadLine();
        }
    }
}
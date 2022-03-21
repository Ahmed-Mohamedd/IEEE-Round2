using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("enter a word ");
            word = Console.ReadLine();
            findingNonRepeatingChars(word.ToLower());      
            Console.ReadLine();
        }

        private static void findingNonRepeatingChars(string word)
        {
            ArrayList result = new ArrayList();

            foreach (char c in word)
            {
                if (result.IndexOf(c) == -1)
                {
                    result.Add(c);
                }
                else
                {
                    result.RemoveAt(result.IndexOf(c));
                }

            }
            Console.WriteLine("the first non-repeating char is  " + result[0]); // first non-repeating char 

            for (int i = 1; i < result.Count; i++) // the rest of non repeating chars if found
            {
                Console.WriteLine("the other non-repeating chars is  " + result[i]);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise2_3();
            Excercise2_9();
        }


        private static void Excercise2_9()
        {
            Console.Write("Tekst: ");
            var line = Console.ReadLine() + " ";
            var wordCount = 0;
            var charsInCurrentWord = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            foreach (var character in line)

            {
                var isSpace = character == ' ';
                if (isSpace)
                {
                    Console.WriteLine("ordlengde = " + charsInCurrentWord);
                    charsInCurrentWord = 0;
                }
                else
                {
                    if (charsInCurrentWord == 0)
                    {
                    }

                    charsInCurrentWord++;
                }

                int total = line.Count(c => vowels.Contains(c));

                Console.WriteLine("Your total number of vowels is: {0}", total);
            }
        }
    }


}



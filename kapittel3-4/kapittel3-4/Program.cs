using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace kapittel3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            exercise3_5();

            //kapittel3_5
        }

        private static void exercise3_5()
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var code = "QWERTYUIOPASDFGHJKLZXCVBNM";
            var txt = Console.ReadLine().ToUpper();
            Console.WriteLine(exercise3_4(txt, code, alphabet));
            var txt2 = Console.ReadLine().ToUpper();
            Console.WriteLine(exercise3_4(txt2, alphabet, code));
        }

        private static string exercise3_4(string txt, string alphabet, string code)
        {
            var result = string.Empty;

            foreach (var character in txt)
            {
                if (character == ' ') result += character;
                var index = alphabet.IndexOf(character);
                result += code[index];
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }
            var length = Convert.ToInt32(args[0]);
            var options = args[1];
            var pattern = options.PadRight(length, 's');
            var password = string.Empty;
            while (pattern.Length > 0)
            {
                var randomIndex = random.Next(0, pattern.Length - 1);
                var category = pattern[randomIndex];
                pattern = pattern.Substring(0, randomIndex) +
                          pattern.Substring(randomIndex + 1, pattern.Length - randomIndex - 1);
                if (category == 'l') password += getRandomLowerCaseLetter();
                else if (category == 'L') password += getRandomUpperCaseLetter();
                else if (category == 'd') password += getRandomDigit();
                else password += getRandomSpecialCharacter();
            }

            Console.WriteLine(password);
        }

        private static char getRandomLowerCaseLetter()
        {
            return getRandomLetter('a', 'z');
        }

        private static char getRandomUpperCaseLetter()
        {
            return getRandomLetter('A', 'Z');
        }

        private static char getRandomLetter(char min, char max)
        {
            return (char) random.Next(min, max);
        }

        private static char getRandomDigit()
        {
            return random.Next(0, 9).ToString()[0];
        }

        private static char getRandomSpecialCharacter()
        {
            var allSpecialCharacters = "!\"#¤%&/(){}[]";
            var index = random.Next(0, allSpecialCharacters.Length - 1);
            return allSpecialCharacters[index];
        }

        private static bool IsValid(string[] args)
        {
            if (args.Length != 2)return false;
            var lengthStr = args[0];
            var options = args[1];

            foreach (var character in options)
            {
                if (character != 'l'
                    && character != 'L'
                    && character != 'd'
                    && character != 's') return false;
            }

            foreach (var character in lengthStr)
            {
                if (!char.IsDigit(character)) return false;
                
            }

            return true;
        }

        private static void ShowHelpText()
        {
            Console.WriteLine("PasswordGenerator <length> <option>");
            Console.WriteLine(" Options:");
            Console.WriteLine(" - l = lower case letter");
            Console.WriteLine(" - L = upper case letter");
            Console.WriteLine(" - d = digit");
            Console.WriteLine(" - s = special character (!\"#¤%&/(){}[]");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("         Min. 1 lower case");
            Console.WriteLine("         Min. 1 upper case");
            Console.WriteLine("         Min. 2 special characters");
            Console.WriteLine("         Min. 2 digits");
        }
    }
}

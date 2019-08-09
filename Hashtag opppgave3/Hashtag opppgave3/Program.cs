using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtag_opppgave3
{
    class Program
    {
        static void Main(string[] args)

        {
            for (int r = 0; r < 4; r++)
            {
                Space(r);
                Hash(8 - 2 * r);
                NewLine();
            }
            NewLine();
            for (int r = 4 - 1; r >= 0; r--)
            {
                Space(r);
                Hash(8 - 2 * r);
                NewLine();
            }
            for (int r = 0; r < 4; r++)
            {
                Space(r);
                Hash(8 - 2 * r);
                NewLine();
            }
            NewLine();
            for (int r = 0; r < 4; r++)
            {
                Space(1+1*r);
                Hash(1+1 * r);
                Space(12-4*r);
                Hash(1+1*r);
                NewLine();
            }
            for (int r = 4 - 1; r >= 0; r--)
            {
                Space(1 + 1 * r);
                Hash(1 + 1 * r);
                Space(12 - 4 * r);
                Hash(1 + 1 * r);
                NewLine();
            }
        }

        private static void Hash(int count)
        {
            for (int r = 0; r < count; r++) Hash();
        }

        private static void NewLine()
        {
            Console.WriteLine();
        }

        private static void Hash()
        {
            Console.Write("#");
        }

        private static void Space()
        {
            Console.Write(" ");
        }
        private static void Space(int count)
        {
            for (int r = 0; r < count; r++) Space();
        }
    }
}

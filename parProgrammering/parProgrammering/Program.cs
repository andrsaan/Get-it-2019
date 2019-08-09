using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parProgrammering
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personNames =
            {
                "Kåre", "Pål", "Rolf", "Espen", "Tore"
            };
            for (var e = 0; e < 10; e++)
            {
                var random = new Random();
                var r = random.Next(0, personNames.Length);
                for (var i = 0; i < personNames.Length; i++)
                {
                    personNames[r] += " *";
                    Console.WriteLine(personNames[r]);
                }

                Console.WriteLine();
            }
        }
    }
}

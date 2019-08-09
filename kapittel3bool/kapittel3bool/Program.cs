using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapittel3bool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tof = true;
            int[] numbers = { 1, 2, 5, 4, 5, 6, 7, 8, 9 };
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    if  (tof == false)
                    {
                        Console.WriteLine("Feil");
                        return;
                    }
                    var lastNumber = numbers[i - 1];
                    var currentNumber = numbers[i];
                    if (currentNumber < lastNumber)
                    {
                        tof = false;
                    }
                }
                Console.WriteLine("Riktig");
            }
        }
    }
}

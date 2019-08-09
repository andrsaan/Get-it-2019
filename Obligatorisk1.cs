using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorisk1
{
    class Program
    
    {
        Person[] Persons;
        static void Main(string[] args)
        {
            var DarthVader = new Person(1) {  FirstName = "DarthVader", BirthYear = 2005 };
            var Leia = new Person( 2)  {  FirstName = "Leia", BirthYear = 2004 };
            var Luke = new Person (3) { Id = 3, FirstName = "Luke", BirthYear = 1973 };
            var Yoda = new Person (4) { Id = 4, FirstName = "Yoda", BirthYear = 1973 };
            var Chewbacca = new Person (5) { FirstName = "Chewbacca", LastName = "Hansen", BirthYear = 1997 };
            var HanSolo = new Person (6) {  FirstName = "Han Solo", BirthYear = 1937 };
            var ObiWan = new Person (7) {  FirstName = "Obi Wan", BirthYear = 1937 };
            var Krok = new Person (8) {  FirstName = "Krok", BirthYear = 1903 };

            Luke.Father = DarthVader;
            Krok.Mother = Leia;
            HanSolo.Father = Chewbacca;
            ObiWan.Mother = Leia;
            Chewbacca.Mother = Leia;
            Yoda.Father = Chewbacca;
            Yoda.Mother = Leia;
            ObiWan.Father = Chewbacca;
        }
    }
}

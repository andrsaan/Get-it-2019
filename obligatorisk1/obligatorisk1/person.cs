using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace obligatorisk1
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int DeathDate { get; set; }
        public int BirthYear { get; set; }
        public Person Father { get; internal set; }
        public Person Mother { get; internal set; }

        public Person(int id)
        {
            Id = id;
            var List = id;


        }
        
    }

    
}

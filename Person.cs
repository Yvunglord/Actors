using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors
{
    public class Person
    {
        public string Name { get; set; }    
        public string Id { get; set; }
        public Person(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

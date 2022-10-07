using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using SOLID principles, refactor the City class to follow best practices.
//The City class should only have properties.
//You will need to make a new class to contain the logic dealing with construction.

namespace Software2KnowledgeCheck1
{
    internal class City
    {
        public int ZipCode { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }

        public List<Building> Buildings { get; } = new List<Building>();


        
    }
}

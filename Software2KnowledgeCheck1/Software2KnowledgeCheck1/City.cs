using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class City
    {
        public int ZipCode { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }

        public List<Building> Buildings { get; } = new List<Building>();

        /*public City(int zipCode, string name, string state, int population, List<Building> buildings)
        {
            ZipCode = zipCode;
            Name = name;
            State = state;
            Population = population;
            Buildings = buildings;
        }*/
    }
}

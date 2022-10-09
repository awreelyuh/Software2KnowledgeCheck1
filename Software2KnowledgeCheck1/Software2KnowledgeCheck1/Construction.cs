using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Construction
    {
        public List<string> Materials { get; set; }
        public int PermitNumber { get; set; }
        public string ZoningCode { get; set; }
        public Building BuildingType { get; set; }

        public static bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T : Building
        {
            if (!permit && !zoning)
            {
                throw new ArgumentException("Permit and zoning approval are both required.");
            }
            else
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...
                }
                return true;
            }
        }
    }
}

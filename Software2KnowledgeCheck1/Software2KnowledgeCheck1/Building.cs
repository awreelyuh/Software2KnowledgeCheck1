using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Building
    {
        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public static void CreateBuilding<T>(T buildingType) where T : Building
        {
            // Get materials
            var materialsNeeded = MaterialsRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = Construction.ConstructBuilding<T>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                BuildingsRepo.Add(buildingType);
            }
        }
    }
}

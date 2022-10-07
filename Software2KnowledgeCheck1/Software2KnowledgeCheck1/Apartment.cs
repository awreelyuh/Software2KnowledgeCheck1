using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Apartment : Building
    {
        public int NumberOfUnits { get; set; }
        public int NumberOfOpenUnits { get; set; }

        public bool HasParking { get; set; }
         
        public void CreateApartment(Apartment apartment)
        {
            // Get materials
            var materialsNeeded = MaterialsRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = Construction.ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                Building.Add(apartment);
            }
        }
    }
}

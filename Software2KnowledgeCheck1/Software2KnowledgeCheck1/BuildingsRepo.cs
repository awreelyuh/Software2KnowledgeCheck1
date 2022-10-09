namespace Software2KnowledgeCheck1
{
    internal class BuildingsRepo
    {
        public static void Add(Building building)
        {
            List<Building> buildings = new();
            buildings.Add(building);
        }
    }
}

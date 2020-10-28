namespace NASA.Robo.Model
{
    public class Area
    {
        public Cordenada TopoArea { get; set; }
        public Cordenada BaseArea { get; set; }

        public Area()
        {

        }
        public Area(Cordenada topoArea, Cordenada baseArea)
        {
            this.TopoArea = topoArea;
            this.BaseArea = baseArea;
        }

    }
}

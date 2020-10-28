using NASA.Robo.Model;

namespace NASA.Robo.Factory
{
    public class AreaFactory
    {
        public int CordenadaYMaxima { get; set; }
        public int CordenadaXMaxima { get; set; }
        public int CordenadaYMinima { get; set; }
        public int CordenadaXMinima { get; set; }
        
        public Area Create()
        {
            Cordenada _top = new Cordenada(0, 5);
            Cordenada _base = new Cordenada(5, 0);
            return new Area(_top, _base);
        }

    }
}

using NASA.Robo.Domain;
using NASA.Robo.Model;

namespace NASA.Robo.Factory
{
    public class RobotFactory
    {

        private AreaFactory areaFactory = new AreaFactory();
        public int cordenadaX { get; set; }
        public int cordenadaY { get; set; }
        public Posicao posicao{ get; set; } 

        public Robot Create()
        {
            posicao = new Posicao();
            Cordenada cordenada = new Cordenada(cordenadaX, cordenadaY);
            Area area = areaFactory.Create();
            return new Robot(area, posicao, cordenada);
        }

    }
}

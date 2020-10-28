using NASA.Robo.Model;

namespace NASA.Robo.Action
{
    public class MoverAcao : IAcao
    {
        public void Aplicar(ref Robot robo)
        {
            int oldX = robo.Cordenada.X;
            int oldY = robo.Cordenada.Y;

            robo.Cordenada.X = oldX + robo.Posicao.IncrementaX;
            robo.Cordenada.Y = oldY + robo.Posicao.IncrementaY;
            
        }
    }
}

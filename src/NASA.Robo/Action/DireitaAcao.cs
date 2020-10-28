using NASA.Robo.Domain;
using NASA.Robo.Model;

namespace NASA.Robo.Action
{
    public class DireitaAcao : IAcao
    {
        public DireitaAcao()
        {

        }
        public void Aplicar(ref Robot robo)
        {
            Posicao _posicao = new Posicao();
            _posicao.IncrementaX = robo.Cordenada.X;
            _posicao.IncrementaY = robo.Cordenada.Y;
            robo.Posicao = robo.Posicao.GetDireita();
            robo.Cordenada.X = _posicao.IncrementaX;
            robo.Cordenada.Y = _posicao.IncrementaY;
            
        }
    }
}

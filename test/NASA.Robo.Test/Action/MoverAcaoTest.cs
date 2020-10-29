using NASA.Robo.Action;
using NASA.Robo.Domain;
using NASA.Robo.Model;
using Xunit;

namespace NASA.Robo.Test.Action
{
    public class MoverAcaoTest
    {
        private MoverAcao _moverAcao;
        private readonly Posicao _posicao;
        public MoverAcaoTest()
        {
            _moverAcao = new MoverAcao();
            _posicao = new Posicao();
        }

        private Robot CreateRobot(Posicao posicao)
        {
            Cordenada cordenada = new Cordenada(0, 0);
            return new Robot(null, posicao, cordenada);
        }

        [Fact]
        public void Mover_Para_North_IncrementaY_Test() 
        {
            Robot xpto = CreateRobot(_posicao.getNORTH());
            _moverAcao.Aplicar(ref xpto);
            Assert.Equal(0, xpto.Cordenada.X);
            Assert.Equal(1, xpto.Cordenada.Y);
        }

        [Fact]
        public void Mover_Para_East_IncrementaY_Test()
        {
            Robot xpto = CreateRobot(_posicao.getEAST());
            _moverAcao.Aplicar(ref xpto);
            Assert.Equal(0, xpto.Cordenada.Y);
            Assert.Equal(1, xpto.Cordenada.X);
        }

        [Fact]
        public void Mover_Para_South_IncrementaY_Test()
        {
            Robot xpto = CreateRobot(_posicao.getSOUTH());
            _moverAcao.Aplicar(ref xpto);
            Assert.Equal(-1, xpto.Cordenada.Y);
            Assert.Equal(0, xpto.Cordenada.X);
        }

        [Fact]
        public void Mover_Para_Weast_IncrementaY_Test()
        {
            Robot xpto = CreateRobot(_posicao.getWEST());
            _moverAcao.Aplicar(ref xpto);
            Assert.Equal(0, xpto.Cordenada.Y);
            Assert.Equal(-1, xpto.Cordenada.X);
        }

    }
}

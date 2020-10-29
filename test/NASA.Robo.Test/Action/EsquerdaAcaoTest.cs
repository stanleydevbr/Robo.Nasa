using NASA.Robo.Action;
using NASA.Robo.Domain;
using NASA.Robo.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NASA.Robo.Test.Action
{
    public class EsquerdaAcaoTest
    {
        private readonly EsquerdaAcao _acaoEsquerda;
        private readonly Posicao _posicao;
        public EsquerdaAcaoTest()
        {
            _acaoEsquerda = new EsquerdaAcao();
            _posicao = new Posicao();
        }

        private Robot CreateRobot(Posicao posicao)
        {
            Cordenada cordenada = new Cordenada(0, 0);
            return new Robot(null, posicao, cordenada);
        }

        [Fact]
        public void Acao_Esquerda_EastToNorthTest()
        {
            //Ambiente
            var xpto = CreateRobot(_posicao.getSOUTH());
            //Ação
            _acaoEsquerda.Aplicar(ref xpto);
            //Acertos
            Assert.Equal(_posicao.getEAST(), xpto.Posicao);
        }

        [Fact]
        public void Acao_Esquerda_EastToSouthTest()
        {
            //Ambiente
            var xpto = CreateRobot(_posicao.getSOUTH());
            //Ação
            _acaoEsquerda.Aplicar(ref xpto);
            //Acertos
            Assert.Equal(_posicao.getEAST(), xpto.Posicao);
        }

        [Fact]
        public void Acao_Esquerda_NorthToEasthTest()
        {
            //Ambiente
            var xpto = CreateRobot(_posicao.getEAST());
            //Ação
            _acaoEsquerda.Aplicar(ref xpto);
            //Acertos
            Assert.Equal(_posicao.getNORTH(), xpto.Posicao);
        }

        [Fact]
        public void Acao_Esquerda_SouthToWeastTest()
        {
            //Ambiente
            var xpto = CreateRobot(_posicao.getWEST());
            //Ação
            _acaoEsquerda.Aplicar(ref xpto);
            //Acertos
            Assert.Equal(_posicao.getSOUTH(), xpto.Posicao);
        }

    }
}

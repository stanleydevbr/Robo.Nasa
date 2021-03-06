﻿using NASA.Robo.Action;
using NASA.Robo.Domain;
using NASA.Robo.Model;
using Xunit;

namespace NASA.Robo.Test.Action
{

    public class DireitaAcaoTest
    {
        private readonly DireitaAcao _acaoDireita;
        private readonly Posicao _posicao;
        public DireitaAcaoTest()
        {
            _acaoDireita = new DireitaAcao();
             _posicao = new Posicao();
        }

        private Robot CreateRobot(Posicao posicao)
        {
            Cordenada cordenada = new Cordenada(0, 0);
            return new Robot(null, posicao, cordenada);
        }

        [Fact]
        public void Acao_Direita_EastToNorthTest()
        {
            //Ambiente
            var xpto = CreateRobot(_posicao.getNORTH());
            //Ação
            _acaoDireita.Aplicar(ref xpto);
            //Acertos
            Assert.Equal(_posicao.getEAST(), xpto.Posicao);
        }

        [Fact]
        public void Acao_Direita_WestToSouthTest()
        {
            //Ambiente
            var xpto = CreateRobot(_posicao.getSOUTH());
            //Ação
            _acaoDireita.Aplicar(ref xpto);
            //Acertos
            Assert.Equal(_posicao.getWEST(), xpto.Posicao);
        }

        [Fact]
        public void Acao_Direita_SouthToEastTest()
        {
            //Ambiente
            var xpto = CreateRobot(_posicao.getEAST());
            //Ação
            _acaoDireita.Aplicar(ref xpto);
            //Acertos
            Assert.Equal(_posicao.getSOUTH(), xpto.Posicao);
        }

        [Fact]
        public void Acao_Direita_NorthToWestTest()
        {
            //Ambiente
            var xpto = CreateRobot(_posicao.getWEST());
            //Ação
            _acaoDireita.Aplicar(ref xpto);
            //Acertos
            Assert.Equal(_posicao.getNORTH(), xpto.Posicao);
        }

    }
}

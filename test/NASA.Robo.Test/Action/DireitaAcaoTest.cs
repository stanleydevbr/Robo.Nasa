using NASA.Robo.Action;
using NASA.Robo.Domain;
using NASA.Robo.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NASA.Robo.Test.Action
{
    
    public class DireitaAcaoTest
    {
        private DireitaAcao _acaoDireita;
        public DireitaAcaoTest()
        {
            _acaoDireita = new DireitaAcao();                
        }

        private Robot CreateRobot(Posicao posicao)
        {
            Cordenada cordenada = new Cordenada(0, 0);
            return new Robot(null, posicao, cordenada, "Test");
        }

        [Fact]
        public void Acao_Direita_EastWhenNorthTest()
        {
            //Ambiente
            //Robot xpto = CreateRobot(Posicao.)
            //Ação

            //Acertos
        }




    }
}

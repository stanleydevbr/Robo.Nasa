using NASA.Robo.Action;
using System.Collections.Generic;

namespace NASA.Robo.Factory
{
    public class AcaoFactory
    {
        private readonly static char LEFT = 'L';
        private readonly static char MOVE = 'M';
        private readonly static char RIGHT = 'R';

        private IDictionary<char, IAcao> actions;
        public AcaoFactory() 
        {
            actions = RegistrarAcao();
        }

        public IAcao Get(char code)
        {
            IAcao acao = actions[code];
            return acao;
        }


        private Dictionary<char, IAcao> RegistrarAcao()
        {
            actions = new Dictionary<char, IAcao>();
            actions.Add(LEFT, new EsquerdaAcao());
            actions.Add(RIGHT, new DireitaAcao());
            actions.Add(MOVE, new MoverAcao());
            return (Dictionary<char, IAcao>)actions;
        }
    }
}

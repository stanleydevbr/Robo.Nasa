using NASA.Robo.Action;
using NASA.Robo.Factory;
using System.Collections.Generic;
using System.Linq;

namespace NASA.Robo.Command
{
    public class CommandParse
    {
        private AcaoFactory _acaoFactory =  new AcaoFactory();
        public List<IAcao> parseAcao(string command)
        {
            return command.ToCharArray().Select(c => _acaoFactory.Get(c)).ToList();
        }

        public void SetAcaoFactory(AcaoFactory acaoFactory)
        {
            _acaoFactory  = acaoFactory;
        }

    }
}

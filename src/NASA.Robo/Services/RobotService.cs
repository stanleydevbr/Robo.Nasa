using NASA.Robo.Command;
using NASA.Robo.Factory;
using NASA.Robo.Model;
using NASA.Robo.Validator;

namespace NASA.Robo.Services
{
    public class RobotService
    {
        public CommandParse commandParse { get; set; }
        public RobotFactory robotFactory { get; set; }
        public RobotValidator robotValidador { get; set; }
        public RobotService()
        {
            commandParse = new CommandParse();
            robotFactory = new RobotFactory();
            robotValidador = new RobotValidator();
        }

        public Robot mover(string command)
        {
            Robot robot = robotFactory.Create();
            var aux = commandParse.parseAcao(command);
            commandParse.parseAcao(command)
                .ForEach(a  =>
                {
                    a.Aplicar(ref robot);
                    robotValidador.ValidarFronteira(robot.Area, robot.Cordenada);
                });
            return robot;
        }


    }
}

using Microsoft.AspNetCore.Mvc;
using NASA.Robo.Services;

namespace NASA.Robo.Controllers
{
    [Route("api/robot")]   
    
    public class RobotController : BaseController
    {
        private RobotService _robotService;
        public RobotController()
        {
            _robotService = new RobotService();
        }

        [HttpPost("mover")]
        public IActionResult Mover(string command)
        {
            try
            {
            var robot = _robotService.mover(command);
            return Ok(robot.ToString());
            }
            catch (System.Exception)
            {
                return BadRequest("Posição inválida.");
            }
        }
    }
}

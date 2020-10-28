using NASA.Robo.Model;
using System;

namespace NASA.Robo.Validator
{
    public class RobotValidator
    {
        public void ValidarFronteira(Area area, Cordenada cordenada)
        {
            int x = cordenada.X;
            int y = cordenada.Y;
            if (!AreaY(area, y) || !AreaX(area, x))
            {
                throw new Exception("Posição inválida.");
            }
        }

        private bool AreaY(Area area, int y)
        {
            return area.BaseArea.Y <= y && area.TopoArea.Y >= y;
        }

        private bool AreaX(Area area, int x)
        {
            return area.BaseArea.Y <= x && area.TopoArea.Y >= x;
        }
    }
}

using NASA.Robo.Domain;
using System;
using System.Text;

namespace NASA.Robo.Model
{
    public class Robot
    {
        public Posicao Posicao; 
        public Cordenada Cordenada { get; set; }
        public Area Area { get; set; }
        public Guid ID { get; set; }

        public Robot()
        {
            Posicao = new Posicao();
            Cordenada = new Cordenada();
            Area = new Area();
        }
        public Robot(Area area, Posicao posicao, Cordenada cordenada)
        {
            Area = area;
            Posicao = posicao;
            Cordenada = cordenada;
            ID = Guid.NewGuid();
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder
                .Append("(")
                .Append(this.Cordenada.X)
                .Append(",")
                .Append(this.Cordenada.Y)
                .Append(",")
                .Append(this.Posicao.Label)
                .Append(")");
            return builder.ToString();
        }

    }
}

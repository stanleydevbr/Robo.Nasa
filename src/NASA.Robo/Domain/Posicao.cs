using System.Collections.Generic;

namespace NASA.Robo.Domain
{
    public class Posicao: Enumerador
    {
        private static Posicao NORTH = new Posicao ("N", 0, 1);
        private static Posicao EAST = new Posicao("E", 1, 0);
        private static Posicao SOUTH = new Posicao("S", 0, -1);
        private static Posicao WEST = new Posicao("W", -1, 0);

        public Posicao()
            :base("",0, 0)
        {
            this.IncrementaX = NORTH.IncrementaX;
            this.IncrementaY = NORTH.IncrementaY;
            this.Label = NORTH.Label;
        }

        public Posicao(string label, int incrementaX, int incrementaY)
            :base(label, incrementaX, incrementaY)
        {
        }

        public Posicao GetEsquerda()
        {
            return Label switch
            {
                "N" => WEST,
                "S" => EAST,
                "E" => NORTH,
                _ => SOUTH,
            };
        }
        public Posicao GetDireita()
        {
            return Label switch
            {
                "N" => EAST,
                "S" => WEST,
                "E" => SOUTH,
                _ => NORTH,
            };
        }

        public Posicao getEAST() => EAST;
        public Posicao getWEST() => WEST;
        public Posicao getSOUTH() => SOUTH;
        public Posicao getNORTH() => NORTH;

    }

    public abstract class Enumerador
    {

        public int IncrementaX { get;  set; }
        public int IncrementaY { get;  set; }
        public string Label { get; set; }

        public Enumerador( string label, int incrementaX, int incrementaY)
        {
            this.IncrementaX = incrementaX;
            this.IncrementaY = incrementaY;
            this.Label = label;
            
        }


    }


}

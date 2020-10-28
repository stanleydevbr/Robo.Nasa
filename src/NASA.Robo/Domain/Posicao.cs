using System.Collections.Generic;

namespace NASA.Robo.Domain
{
    public class Posicao: Enumerador
    {
        public static Posicao NORTH = new Posicao ("N", 0, 1);
        public static Posicao EAST = new Posicao("E", 1, 0);
        public static Posicao SOUTH = new Posicao("S", 0, -1);
        public static Posicao WEST = new Posicao("W", -1, 0);

        public string Label { get; set; }

        private static readonly List<Posicao> listaPosicao = new List<Posicao>()
        {
            Posicao.NORTH,
            Posicao.EAST,
            Posicao.SOUTH,
            Posicao.WEST
        };

        public Posicao()
            :base(0, 0)
        {
            this.IncrementaX = NORTH.IncrementaX;
            this.IncrementaY = NORTH.IncrementaY;
            this.Label = NORTH.Label;
        }

        public Posicao(string label, int incrementaX, int incrementaY)
            :base(incrementaX, incrementaY)
        {
            Label = label;
        }

        public static List<Posicao> ListaPosicao()
        {
            return listaPosicao;
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
    }

    public abstract class Enumerador
    {

        public int IncrementaX { get; set; }
        public int IncrementaY { get; set; }

        public Enumerador( int incrementaX, int incrementaY)
        {
            this.IncrementaX = incrementaX;
            this.IncrementaY = incrementaY;
            
        }


    }


}

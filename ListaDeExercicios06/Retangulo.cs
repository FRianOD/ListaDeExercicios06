using System;

namespace ListaDeExercicios06
{
    internal class Retangulo
    {
        public double L { get; private set; }
        public double H { get; private set; }

        public Retangulo(double l, double h)
        {
            L = l;
            H = h;
        }

        public double Area()
        {
            return L * H;
        }

        public double Perimetro() 
        {
            return ( 2 * L ) + ( 2 * H );
        }
        public double Diagonal() 
        {
            return Math.Sqrt( L * L + H * H );
        }
    }
}

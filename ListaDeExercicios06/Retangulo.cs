using System;

namespace ListaDeExercicios06
{
    internal class Retangulo
    {
        public double A;
        public double B;

        public double Area()
        {
            return A * B;
        }

        public double Perimetro() 
        {
            return ( 2 * A ) + ( 2 * B );
        }
        public double Diagonal() 
        {
            return Math.Sqrt( A * A + B * B );
        }
    }
}

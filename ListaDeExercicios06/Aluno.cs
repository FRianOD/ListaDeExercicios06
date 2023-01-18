using System;
using System.Globalization;

namespace ListaDeExercicios06
{
    internal class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return (N1 + N2 + N3);
        }
    }
}

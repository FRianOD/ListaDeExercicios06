using System;
using System.Globalization;

namespace ListaDeExercicios06
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double N1 { get; private set; }
        public double N2 { get; private set; }
        public double N3 { get; private set; }

        public Aluno(string nome, double n1, double n2, double n3) 
        {
            Nome = nome;
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }

        public double NotaFinal()
        {
            return (N1 + N2 + N3);
        }
    }
}

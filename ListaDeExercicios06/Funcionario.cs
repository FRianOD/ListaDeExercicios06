using System;
using System.Globalization;

namespace ListaDeExercicios06
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; private set; }
        public double Impostos { get; private set; }

        public Funcionario(string nome, double salarioBruto, double impostos) 
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Impostos = impostos;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100.0));
        }
        public override string ToString()
        {
            return $"{Nome}, ${(SalarioBruto - Impostos).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

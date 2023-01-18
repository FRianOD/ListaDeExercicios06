using System;
using System.Globalization;

namespace ListaDeExercicios06
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Impostos;

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

using System;
using System.Globalization;

namespace ListaDeExercicios06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 0 = Retangulo
            
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            r.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Área = {(r.Area()).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {(r.Perimetro()).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {(r.Diagonal()).ToString("F2", CultureInfo.InvariantCulture)}");
            
            //Problema 1 = Funcionario

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Impostos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"\nFuncionario: {f}\n");

            Console.Write($"Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);

            Console.WriteLine($"\nFuncionario: {f}\n");
            
            //Problema 2 = Aluno

            Aluno a = new Aluno();

            Console.Write($"Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {(a.NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)}");

            if (a.NotaFinal() >= 60.0)
            {
                Console.WriteLine("APROVADO");
            } else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {(60.00 - a.NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }

        }
    }
}
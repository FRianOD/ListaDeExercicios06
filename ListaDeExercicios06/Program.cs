using System;
using System.Globalization;

namespace ListaDeExercicios06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 0 = Retangulo
            
            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Retangulo r = new Retangulo(largura, altura);

            Console.WriteLine($"Área = {(r.Area()).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {(r.Perimetro()).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {(r.Diagonal()).ToString("F2", CultureInfo.InvariantCulture)}");
            
            //Problema 1 = Funcionario

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            double impostos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Funcionario f = new Funcionario(nome, salarioBruto, impostos);
            
            Console.WriteLine($"\nFuncionario: {f}\n");

            Console.Write($"Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);

            Console.WriteLine($"\nFuncionario: {f}\n");
            
            //Problema 2 = Aluno

            Console.Write($"Nome do Aluno: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno a = new Aluno(nome2, n1, n2, n3);

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
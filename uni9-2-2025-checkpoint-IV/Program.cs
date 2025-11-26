// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o salário bruto:");
        double salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o desconto do INSS:");
        double descontoINSS = double.Parse(Console.ReadLine());

        double irrf = CalculadoraIRRF.Calcular(salario, descontoINSS);
        Console.WriteLine($"IRRF calculado: {irrf}");
    }
}

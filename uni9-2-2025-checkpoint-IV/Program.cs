// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Program
{
 public static void Main()
'' {
                
double salarioBruto = 3000.00;
 double inss = 258.83;
CalculadoraIRRF calculadora = new CalculadoraIRRF();

double irrf = calculadora.Calcular(salarioBruto, inss);

Console.WriteLine("IRRF: " + irrf.ToString("F2"));
    }
}
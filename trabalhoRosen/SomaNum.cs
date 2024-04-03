using System;

class SomaNum
{
   public static void CalcularSoma()
    {
        try
        {
            Console.WriteLine("Bem-vindo à Calculadora de Soma!");
            Console.WriteLine("Por favor, insira dois números para calcular a soma.");

            // Entrada num1
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Entrada num2 
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Calculo
            double soma = num1 + num2;

            // Resposta
            Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
        }
        // Detector de erros especificos

        // Caso seja uma entrada não convertivel
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira valores numéricos válidos.");
        }
       // Caso seja outro tipo de erro
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}

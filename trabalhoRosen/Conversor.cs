using System;

class Conversor
{

    public static void ConversorFunction()
    {
        try
        {
            Console.WriteLine("Bem-vindo ao Conversor de Metros para Milímetros e vice-versa!");
            Console.WriteLine("Por favor, escolha a conversão desejada:");
            Console.WriteLine("0. Metro para Milímetro");
            Console.WriteLine("1. Milímetro para Metro");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 0)
            {
                ConverterMetroParaMilimetro();
            }
            else if (opcao == 1)
            {
                ConverterMilimetroParaMetro();
            }
            else
            {
                Console.WriteLine("Opção inválida. Burro");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Opção inválida. Por favor, insira um número.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }

    static void ConverterMetroParaMilimetro()
    {
        try
        {
            Console.WriteLine("Digite o valor em metros para converter para milímetros:");
            double metros = Convert.ToDouble(Console.ReadLine());

            double milimetros = metros * 1000;

            Console.WriteLine($"{metros} metros equivalem a {milimetros} milímetros.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um valor numérico válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }

    static void ConverterMilimetroParaMetro()
    {
        try
        {
            Console.WriteLine("Digite o valor em milímetros para converter para metros:");
            double milimetros = Convert.ToDouble(Console.ReadLine());

            double metros = milimetros / 1000;

            Console.WriteLine($"{milimetros} milímetros equivalem a {metros} metros.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um valor numérico válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}

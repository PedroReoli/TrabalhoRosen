using System;


    class Palindromo
{
    public static void VerificarPalindromo()
    {
        // Declaração das variáveis utilizadas
        int numero, inversoN, aux;

        // Solicita ao usuário para digitar o número
        Console.Write("Digite o Número: ");
        numero = int.Parse(Console.ReadLine());

        // Inicializa a variável inversoN como zero
        inversoN = 0;

        // Salva o valor original do número em aux
        aux = numero;

        // Constrói o número inverso
        while (aux > 0)
        {
            // Multiplica o inverso por 10 e adiciona o último dígito do número original
            inversoN = (inversoN * 10) + (aux % 10);
            // Remove o último dígito do número original
            aux = aux / 10;
        }

        // Exibe o número original e o número inverso
        Console.WriteLine("\nNúmero: {0}\nNumero invertido: {1}\n", numero, inversoN);

        // Verifica se o número original é igual ao número inverso
        if (numero == inversoN)
        {
            Console.WriteLine("São palíndromos.\n\n");
        }
        else
        {
            Console.WriteLine("Não são palíndromos.\n\n");
        }
        Console.ReadKey();
    }
}
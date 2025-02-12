using System;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Calculadora =====");
                Console.WriteLine("Selecione a operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "5") break;

                Console.Write("Digite o primeiro número: ");
                double numero1 = ObterNumeroValido();

                Console.Write("Digite o segundo número: ");
                double numero2 = ObterNumeroValido();

                double resultado = Calcular(opcao, numero1, numero2);
                Console.WriteLine($"Resultado: {resultado}");

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        static double ObterNumeroValido()
        {
            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida. Digite um número válido: ");
            }
            return numero;
        }

        static double Calcular(string operacao, double number1, double number2)
        {
            return operacao switch
            {
                "1" => number1 + number2,
                "2" => number1 - number2,
                "3" => number1 * number2,
                "4" => number2 != 0 ? number1 / number2 : throw new DivideByZeroException("Erro: Divisão por zero!"),
                _ => throw new ArgumentException("Operação inválida")
            };
        }
    }
}

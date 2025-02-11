using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Calculadora em .NET");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");

            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "0") break;

            Console.Write("Digite o primeiro número: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double resultado = opcao switch
            {
                "1" => number1 + number2,
                "2" => number1 - number2,
                "3" => number1 * number2,
                "4" => number2 != 0 ? number1 / number2 : throw new DivideByZeroException("Erro: Divisão por zero!"),
                _ => throw new ArgumentException("Opção inválida!")
            };

            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}


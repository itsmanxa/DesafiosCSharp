namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculadora com operações básicas ===");
            Console.WriteLine();
            
            // TODO: Implemente seu código aqui
            Console.WriteLine("Bem-vindo à Calculadora Simples!");
            
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = 0;
            resultado = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            resultado = num1 - num2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            resultado = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            resultado = num1 / num2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            if (num2 != 0)
            {
                resultado = num1 % num2;
                Console.WriteLine($"O resultado do módulo é: {resultado}");
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida para o cálculo do módulo.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

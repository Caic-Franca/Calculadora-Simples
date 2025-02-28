namespace Calculadora_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, opcao, soma, divisao, multiplicacao, subtracao;
            Console.WriteLine("Olá, estamos aqui para te ajudar com as 4 opreções matemáticas simples. :D ");
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine(" 1 - Soma \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divião: \n 5 - todas");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Por favor, digite o primeiro número da operação: .");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor, digite o segundo número da operação: .");
                    num2 = int.Parse(Console.ReadLine());
                    soma = num1 + num2;
                    Console.WriteLine($"A soma dos números digitados é {soma}");

                    break;

                case 2:
                    Console.WriteLine("Por favor, digite o primeiro número da operação: .");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor, digite o segundo número da operação: .");
                    num2 = int.Parse(Console.ReadLine());
                    subtracao = num1 - num2;
                    Console.WriteLine($"A subtração dos números digitados é {subtracao}.");
                    break;

                case 3:
                    Console.WriteLine("Por favor, digite o primeiro número da operação: .");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor, digite o segundo número da operação: .");
                    num2 = int.Parse(Console.ReadLine());
                    multiplicacao = num1 * num2;
                    Console.WriteLine($"A multiplicação dos números digitados é {multiplicacao}");
                    break;
                case 4:
                    Console.WriteLine("Por favor, digite o primeiro número da operação: .");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor, digite o segundo número da operação: .");
                    num2 = double.Parse(Console.ReadLine());
                    divisao = num1 / num2;
                    Console.WriteLine($"A divisão dos números digitados é {divisao}.");
                    break;
                case 5:
                    Console.WriteLine("Ok, saindo uma resposta completa... ");
                    Console.WriteLine("Por favor, digite o primeiro número da operação: .");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor, digite o segundo número da operação: .");
                    num2 = double.Parse(Console.ReadLine());
                    soma = num1 + num2; divisao = num1 / num2; multiplicacao = num1 * num2; subtracao = num1 - num2;
                    Console.WriteLine($"Vamos lá: \nA soma dos números é: {soma}. \nA subtração é: {subtracao}. \nA divisão é: {divisao}. \nE a multiplicação é: {multiplicacao}.");
                    break;
            }

            if (opcao > 5)
            {
                Console.WriteLine("Opção inválida, por favor, tente novamente.");
            }

            Console.WriteLine("Obrigado por usar nossa calculadora, volte sempre! :D");
        }
    }
}
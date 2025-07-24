// operadores aritmeticos

namespace aula5;

public class Program
{
    public static void Main()
    {   
        // variables
        int number = 10;
        int number1 = 20;
        int number2 = 5;
        int sum = number + number1;
        int sub = number1 - number;
        int mult = number1 * number;
        int div = number1 / number2;
        int module = 4 % 3;
        // Outputs
        Console.WriteLine("Exemplo operação de soma: " + sum);
        Console.WriteLine("Exemplo operação de subtração: " + sub);
        Console.WriteLine("Exemplo operação de multiplicação: " + mult);
        Console.WriteLine("Exemplo operação de divisão: " + div);
        Console.WriteLine("Exemplo operação de modulo: " + module);
        
        // tambem é possivel fazer um calculo dentro do metodo writeline por exemplo
        Console.WriteLine(20 + 30);
        // quando usamos um conta interpolada em um string usamos os parenteses para indicar
        // que a conta é feita separamente e exibir apenas seu valor senão a saida seria 3020 
        Console.WriteLine("O resultado da conta 30 + 20 é: " + (30 + 20));
        
        // fazendo teste lempando o console
        Console.WriteLine("Você deseja limpar o terminal?");
        Console.WriteLine("[0]Não [1]Sim");
        int resposta = Convert.ToInt16(Console.ReadLine());
        if (resposta == 1)
        {
            Console.Clear();
        } 
        else if (resposta == 0)
        {
            Console.WriteLine("Pode ficar o tempo que quiser :D !!!");
        }
        else
        {
            Console.WriteLine("Resposta invalida ou não reconhecida");
        }
        
        Console.WriteLine("========Calculadora Simples========");
        Console.WriteLine("Digite o primeiro valor: ");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int value2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("================================");

        int soma = value + value2;
        int divi = value / value2;
        int multi = value * value2;
        
        Console.WriteLine("Valores das operações: ");
        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Divisão: " + divi);
        Console.WriteLine("Multiplicação: " + multi);

    }
}
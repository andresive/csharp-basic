// calculadora simples 

namespace aula10;

public class Program
{
    public static void Main()
    {
        // inicio do programa
        Console.WriteLine("======================");
        Console.WriteLine(" CALCULADORA SIMPLES ");
        Console.WriteLine("======================\n");
        
        Console.WriteLine("Digite o primeiro numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        // selecionando o tipo de operação
        Console.WriteLine("\nSelecione um tipo de operação:");
        Console.WriteLine("1- adição(+)");
        Console.WriteLine("2- subtração(-)");
        Console.WriteLine("3- multiplicação(*)");
        Console.WriteLine("4- divisão(/)");
        Console.WriteLine("Digite o numero da operação: ");
        int operacao = Convert.ToInt16(Console.ReadLine());

        string msg = "";
        double result = 0;
        
        // condições
        if (operacao == 1)
        {
            result = num1 + num2;
            msg = "Adição";
        } else if (operacao == 2)
        {
            result = num1 - num2;
            msg = "Subtração";
        }
        else if (operacao == 3)
        {
            result = num1 * num2;
            msg = "Multiplicação";
        }
        else if (operacao == 4)
        {
            if (num2 != 0) //operador diferente de
            {
                result = num1 / num2;
                msg = "Divisão";
            }
            else
            {
                Console.WriteLine("Erro: O valor de " + num2 + " inserido é invalido");
            }
        }
        else
        {
            Console.WriteLine("Operação invalida!!");
        }
        
        Console.WriteLine("======================");
        Console.WriteLine("O resultado da operação de " + msg);
        Console.WriteLine("======================");
        Console.WriteLine("Do valor " + num1 + " Com o valor " + num2);
        Console.WriteLine("É de: " + result);
    }
}
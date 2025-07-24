// calculadora simples 

namespace aula10;

public class Program
{
    public static void Main()
    {
        // fazendo o progrma se repetir
        bool variable = true;
        
        while (variable)
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
            
            // inicializando variaveis
            string msg = "";
            double result = 0;
            string nonvalid = "Operação invalida!!";
            
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
                Console.WriteLine(nonvalid);
            }
        
            Console.WriteLine("======================");
            Console.WriteLine("O resultado da operação de " + msg);
            Console.WriteLine("======================");
            Console.WriteLine("Do valor " + num1 + " Com o valor " + num2);
            Console.WriteLine("É de: " + result + "\n");
            
            // verificando sse o usuario quer fazer mais uma operação
            Console.WriteLine("Você deseja fazer mais uma operação?");
            Console.WriteLine("[1] Sim");
            Console.WriteLine("[2] Não");
            int cont = Convert.ToInt16(Console.ReadLine());

            if (cont == 1)
            {
                variable = true;
            }
            else if (cont == 2)
            {
                variable = false;
            }
            else
            {
                Console.WriteLine(nonvalid);
            }
            
            // verificando sse o usuario quer limpar o historico do terminal
            Console.WriteLine("Você deseja limpar o historico?");
            Console.WriteLine("[1] Sim");
            Console.WriteLine("[2] Não");
            int clean = Convert.ToInt16(Console.ReadLine());
            
            if (clean == 1) 
            {
                Console.Clear();
            }
            else if (clean == 2)
            {
                
            }
            else
            {
                Console.WriteLine(nonvalid);
            }
        }
        
        Console.WriteLine("Obrigado por usar meu programa :D");
    }
}
// programa usando o switch


using System.Runtime.InteropServices;

namespace aula11_1;

public class Program
{
    public static void Main()
    {
        // programa que verifica o dia da semana 
        // inicio do programa 
        
        Console.WriteLine("===========================");
        Console.WriteLine(" VERIFICADOR DA SEMANA ");
        Console.WriteLine("===========================");
        
        Console.WriteLine("Digite um numero de 1 a 7");
        int day = Convert.ToInt32(Console.ReadLine());

        // declarando variaveis 
        bool exception = false;
        string msg = "";
        
        switch (day) 
        {
            case 1:
                msg = "Domingo";
                break;
            case 2:
                msg = "Segunda-feira";
                break;
            case 3:
                msg = "Terça-feira";
                break;
            case 4:
                msg = "Quarta-feira";
                break;
            case 5:
                msg = "Quinta-feira";
                break;
            case 6:
                msg = "Sexta-feira";
                break;
            case 7:
                msg = "Sabado";
                break;
            default:
                exception = true;
                Console.WriteLine("valor fornecido invalido");
                break;
        }

        if (!exception)
        {
            Console.WriteLine("O dia da semana é: " + msg);
            Console.WriteLine("Tenha um bom dia!!");
        }
        else
        {
            Console.WriteLine("Tente novamente");
        }
        
    }
}
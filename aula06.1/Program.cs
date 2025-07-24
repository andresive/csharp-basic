// estrutura condicional

namespace aula6;

public class Program
{
    public static void Main()
    {
        // verificador de numeros pares e impares
        
        Console.WriteLine("======================");
        Console.WriteLine("verificador de numeros");
        Console.WriteLine("======================");
        Console.WriteLine("Escreva seu numero: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.Clear();
            Console.WriteLine("o valor " + number);
            Console.WriteLine("É Par");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O valor: " + number);
            Console.WriteLine("É Impar");
        }
    }
}
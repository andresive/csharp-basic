// Estrutura condicional

namespace aula6;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Qual é a sua idade?");
        int age = Convert.ToInt16(Console.ReadLine());
    
        // estrutura condicional if 
        if (age >= 18) //verificando o valor
        {
            Console.WriteLine("Você ja é maior de idade!!");
        }
        else
        {
            Console.WriteLine("Você não é maior de idade :( !!");
        }

        
        
    }
}
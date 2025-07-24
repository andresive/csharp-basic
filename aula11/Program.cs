// switch 

// o else do switch é a palavra defalt dentro do switch
namespace aula11;

public class Program
{
    public static void Main()
    {
        
        int number = 1;
        bool test = true;
        
        // o switch funciona como um if porem com valores especificos
        switch (number)
        {
            case 1:
                Console.WriteLine("O numero é 1");
                break;
            case 2:
                Console.WriteLine("O numero é 2");
                break;
        }

        switch (test)
        {
            case true:
                Console.WriteLine("A variavel é verdadeira!!");
                break;
            case false:
                Console.WriteLine("A variavel é falsa!!");
                break;
        } 

    }
}
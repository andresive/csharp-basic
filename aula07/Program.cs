// operadores de atribuicao

namespace aula7;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(" Operadores de atribuição");
        int x = 10;
        Console.WriteLine("\nValor inicial de X: " + x);
        
        // operador de atribuicao simples 
        x = 20;
        Console.WriteLine("\nOperador de atribuição simples");
        Console.WriteLine("Valo de X: " + x);
        
        // operador atribuicao composta
        // é um operador que adiciona ou diminui o valor da varivel em 1 
        // ou adicionar um valor usando o proprio valor da variavel exemplo:
        
        x++;
        Console.WriteLine("\nOperador de atribuição composta (adicionando)");
        Console.WriteLine("O valor de x è: " + x);
        
        x = x + 10;
        Console.WriteLine("Operador de atribuição composta (valor especifico)");
        Console.WriteLine("o valor de x agora é: " + x);
        
        // tambem é possivel fazer essa atribuição de outra forma
        x += 5;
        Console.WriteLine("Operador de atribuição composta (valor especifico adição)");
        Console.WriteLine("O valor de x agora é: " + x);
           
        // tambem é possivel fazer essa mesma operação com outros operadores aritmeticos
        x -= 5;
        Console.WriteLine("Operador de atribuição composta (valor especifico subtração)");
        Console.WriteLine("O valor de x agora é: " + x);
        
        x *= 5;
        Console.WriteLine("Operador de atribuição composta (valor especifico multiplicação)");
        Console.WriteLine("O valor de x agora é: " + x);
        
        x /= 5;
        Console.WriteLine("Operador de atribuição composta (valor especifico divisão)");
        Console.WriteLine("O valor de x agora é: " + x);
        
        x--;
        Console.WriteLine("Operador composto (subtraindo)");
        Console.WriteLine("O valor de x agora é: " + x);
        
        
    }
}
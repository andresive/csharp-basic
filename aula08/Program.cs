// operadores relacionais

//OBS: esse codigo poderia ser bem melhor mas é só para aprender a usar esses operadores
//nessa linguagem ent fiz de qualquer forma porem um dev consegue entender esse codigo
// tranquilamente

namespace aula8;

public class Program
{
    public static void Main()
    {  
        Console.WriteLine(" Operadores relacionais");
        Console.WriteLine("Digite o primeiro numero");
        int num = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo numero");
        int num1 = Convert.ToInt16(Console.ReadLine());

        // Operador de igualdade (==)

        string result;
        
        if (num == num1)
        {
            result = "Os numeros são iguais";
        }
        else
        {
            result = "Os numeros não são iguais";
        }
        // exibindo resultado
        
        Console.WriteLine("\nOperador de igualdade");
        Console.WriteLine(result);
        
        // operador de diferenca (!=)

        if (num != num1)
        {
            result = "Os dois numeros são diferentes";
        }
        else
        {
            result = "Os numeros são iguais";
        }
        
        Console.WriteLine("\nOperador de diferença");
        Console.WriteLine(result);
        
        // Operador maior que (>)


        if (num == num1)
        {
            result = "Os valores são iguais";
        }
        else
        {
            if (num > num1)
            {
                result = "o primeiro valor é maior que o segundo";
            }
            else
            {
                result = "o segundo valor é maior que primeiro";
            }
        }
        
        Console.WriteLine("\nOperador maior que");
        Console.WriteLine(result);
        
        // Operador menor que (<)

        if (num == num1)
        {
            result = "Os valores são iguais";
        }
        else
        {
            if (num < num1)
            {
                result = "o primeiro valor é menor que o segundo";
            }
            else
            {
                result = "o segundo valor é menor que primeiro";
            }
        }
        
        Console.WriteLine("\nOperador menor que");
        Console.WriteLine(result);
        
        // operador maior ou igual (>=)
        if (num >= num1)
        {
            result = "o primeiro valor é maior ou igual ao segundo";
        }
        else
        {
            result = "o segundo valor é maior ou igual ao primeiro";
        }
        
        Console.WriteLine("\nOperador maior ou igual a");
        Console.WriteLine(result);
        
        // operador menor ou igual (<=)
        
        if (num <= num1)
        {
            result = "o primeiro valor é menor ou igual ao segundo";
        }
        else
        {
            result = "o segundo valor é menor ou igual ao primeiro";
        }
        
        Console.WriteLine("\nOperador menor ou igual a");
        Console.WriteLine(result);
        
        
    }
}
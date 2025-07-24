// constantes

namespace aula03;

public class Program
{
    public static void Main()
    {
        // alterando valor de variavel
        int number = 30;

        number = number - 10;
        
        Console.WriteLine("O valor antigo da variavel era: " + number);
        
        number = 10;
        
        Console.WriteLine("O valor da variavel é: " + number);
        
        Console.WriteLine("CONSTANTES");
        
        // o valor de constantes não pode ser alterado 
        const int teste = 1000;
        Console.WriteLine("O valor da constante é de: " + teste);
        
        // tipo de variavel var 
        
        // esse tipo identifica o valor que a variavel esta recebendo e atribui esse tipo para 
        // a variavel automaticamente mas gastando mais memoria e ou processamento
        // sendo uma opção menos otimizada 
        var test = "Nome de usuario";
        Console.WriteLine(test);
        
        // se o valor de uma variavel do tipo var que foi definido como string for
        // alterado para um int (numero inteiro) vai retornar erro
        // Exemplo: 
        
        // test = 500 (isso retornaria um erro)
        
        // tipo de varivel dynamic
        dynamic variable = 20;
        Console.WriteLine("O antigo valor de dynamic é: " + variable);
        // alterando o tipo 
        variable = "testando tipo dinamico";
        Console.WriteLine("O novo valor de dynamic é de: " + variable);
        
        /* no tipo dynamic (dinamico) quando atribuido um tipo diferente do que foi declarado
         * ele não retorna erro por conta que a variavel pode se adaptar ao novo tipo
         * atribuido a ela como no exemplo acima
        */
    }
}
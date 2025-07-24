// o uso da palavra "todo" deixa o codigo azul por conta de uma formatação da IDE 
// usada no codigo que pode identificar como uma palavra para indicar que algo tem que
// ser feito no codigo vindo da fraze to do

// o namespace pode ser usado tanto com chaves como sem chaves 
/* diferença:
 * 
 *  namespace com chaves:
 * define um campo da sua aplicação evitando conflitos de nomes
 * e classes exemplo: namespace MinhaAplicacao {} namespace OutroModulo
 *
 *  namespace com ; (ponto e virgula)
 * define um namespace de escopo de arquivo ou seja o namespace vai
 * pegar o arquivo completo
 */

// Sintaxe basica

// funções e a maioria das coisas começam com letra maiuscula 
// e a linguagem é case semsitive dando erro caso isso não seja seguido

namespace Aula01
{
    public class Progran
    { 
        // o void significa o tipo de dado que a função vai retornar como ela nao vai
        // retornar nada o nome do tipo é void mas se for retornar algum tipo colocar
        // string ou int por exemplo
        public static void Main()
        {
            Console.WriteLine("Iniciando em dotnet");
        }
    }
}

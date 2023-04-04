using ListaExercicios05.Exercicio01;

namespace ListaExercicios05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();

            Console.WriteLine( "O volume da caixa é: " + caixa.CalcularVolume() );
        }
    }
}
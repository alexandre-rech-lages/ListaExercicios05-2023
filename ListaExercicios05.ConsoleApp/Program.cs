using ListaExercicios05.Exercicio01;

namespace ListaExercicios05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();

            caixa.altura = 10;
            caixa.comprimento = 20;
            caixa.largura = 30;

            Console.WriteLine("O volume da caixa é: " + caixa.CalcularVolume());
        }
    }
}
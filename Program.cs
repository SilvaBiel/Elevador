using System;

namespace Elevador
{
    class Program
    {
        static int andares => 5;
     
        static void Main(string[] args)
        {
            var controle = new ControleElevador(andares);
            Console.WriteLine("Digite 0 para sair a qualquer momento");
            Console.WriteLine($"O predio possui {andares} andares");
        }
    }
}
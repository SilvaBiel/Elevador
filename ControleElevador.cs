using System;

namespace Elevador
{
    public class ControleElevador
    {
        public Estado estadoAtual;
        private int andares;
        public ControleElevador(int andaresPredio)
        {
            andares = andaresPredio;
            estadoAtual = new ElevadorParado(1, this);

        }

        public void IniciarElevador()
        {
            while (true)
            {
                Console.WriteLine(estadoAtual.MovimentarElevador());
            }
        }
        
        public int obterAndares()
        {
            return andares;
        }

        public int validateEntrada()
        {
            newEntrada:
            var entrada = Console.ReadLine();

            if (entrada == "0")
                Environment.Exit(0);

            if (!int.TryParse(entrada, out int resultado))
            {
                Console.WriteLine("Configurar entrada do botao para valor somente numerico ou colocar um parse");
                goto newEntrada;
            }
            
            return resultado;
        }

    }
}

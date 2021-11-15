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
    }
}

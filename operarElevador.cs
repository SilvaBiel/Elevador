using System;

namespace Elevador
{
    public class ElevadorDescendo : Estado
    {
        private readonly int _andar;

        public ElevadorDescendo(int andarDesejado, Estado estado)
            : this(estado.AndarAtual, estado.Controle, estado.Elevador)
        {
            _andar = andarDesejado;
        }

        private ElevadorDescendo(int andarAtual, bool[] controle, ControleElevador elevador)
        {
            andar = andarAtual;
            Controle = controle;
            Elevador = elevador;
        }

//Comentando para tentar enviar um push e commitar a alteracao dos nomes
        public override string MovimentarElevador()
        {
            var mensagem = string.Empty;

            if (_andar < 1 || _andar > Elevador.ObterAndares())
                return "Andar inválido.";

            for (int i = AndarAtual; i >= 1; i--)
            {
                if (Controle[i])
                {
                    mensagem = PararNoAndar(_andar);
                    Elevador.EstadoAtual = new ElevadorParado(this);
                    break;
                }
                else
                    continue;
            }

            return mensagem ?? "Andar não encontrado!";
        }
    }
}
using System;

namespace Elevador
{
    public class Estado
    {
        public ControleElevador Elevador { get; set; }
        public int andarAtual { get; set; }
        public bool[] Controle { get; set; }

        public abstract string MovimentarElevador();

        public string AndarDesejado(int andar) 
        {
            Controle[andarAtual] = false;
            Controle[andar] = true;
            andarAtual = andar;

            return ($"Elevador parado no andar {andar} andar");
        }
    }

}

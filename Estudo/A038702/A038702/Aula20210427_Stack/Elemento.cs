using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20210427_Stack {
    class Elemento
    {
        private int valor = -1;
        private Elemento proximo;

        public Elemento() {
            valor = -1;
        }
        public int Valor { get => valor; set => valor = value; }
        public Elemento Proximo { get => proximo; set => proximo = value; }

    }
}

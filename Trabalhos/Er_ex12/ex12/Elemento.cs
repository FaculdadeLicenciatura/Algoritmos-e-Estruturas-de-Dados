using System;
using System.Collections.Generic;
using System.Text;

namespace ex12
{
    class Elemento
    {
        private carro valor;
        private Elemento proximo;

        public Elemento() { }
        public carro Valor { get => valor; set => valor = value; }
        internal Elemento Proximo { get => proximo; set => proximo = value; }
    }
}

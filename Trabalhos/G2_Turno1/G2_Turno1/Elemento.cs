using System;

namespace G2_Turno1 {
    public class Elemento {
        private int valor;
        private Elemento proximo;

        public Elemento() { }
        public int Valor { get => valor; set => valor = Math.Abs(value); }
        public Elemento Proximo { get => proximo; set => proximo = value; }
    }
}
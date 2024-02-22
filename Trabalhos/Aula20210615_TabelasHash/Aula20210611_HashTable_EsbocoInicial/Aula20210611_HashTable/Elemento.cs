namespace Aula20210611_HashTable {
    public class Elemento {
        private Pessoa valor;
        private Elemento proximo;

        public Elemento() { }

        public Elemento Proximo { get => proximo; set => proximo = value; }
        internal Pessoa Valor { get => valor; set => valor = value; }
    }
}
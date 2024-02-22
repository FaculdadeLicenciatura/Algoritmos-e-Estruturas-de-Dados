namespace Aula20210611_HashTable {
    internal class Pessoa {
        private int numero;
        private string nome;

        public string Nome { get => nome; set => nome = value; }
        public int Numero { get => numero; set => numero = value; }

        public Pessoa() { }

        public override string ToString() {
            return string.Format("{0,10}, {1}", Numero, Nome);
        }
    }
}
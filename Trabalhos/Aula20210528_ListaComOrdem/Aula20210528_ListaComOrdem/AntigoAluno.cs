namespace Aula20210528_ListaComOrdem {
    public class AntigoAluno {
        private int numero;
        private string nome;

        public AntigoAluno() { }
        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }

        public override string ToString() {
            return string.Format("{0}, {1}", Numero, Nome);
        }
    }
}
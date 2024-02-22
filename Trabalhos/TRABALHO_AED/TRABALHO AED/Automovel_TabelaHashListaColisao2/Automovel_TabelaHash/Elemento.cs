namespace Automovel_TabelaHash
{
    public class Elemento
    {
        private Automovel valor;
        public Automovel Valor { get => valor; set => valor = value; }

        private Elemento proximo;
        public Elemento Proximo { get => proximo; set => proximo = value; }

        public Elemento() { }
    }
}
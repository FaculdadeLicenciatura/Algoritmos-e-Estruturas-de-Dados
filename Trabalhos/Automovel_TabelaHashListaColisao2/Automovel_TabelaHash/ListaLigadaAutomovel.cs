using System.Text;

namespace Automovel_TabelaHash
{
    public class ListaLigadaAutomovel
    {
        private Elemento cabecaFila;

        public ListaLigadaAutomovel() { cabecaFila = null; }

        public void Adicionar(Automovel automovel)
        {
            Elemento novo = new Elemento { Valor = automovel, Proximo = null };

            if (cabecaFila != null)
            {
                novo.Proximo = cabecaFila;
            }

            cabecaFila = novo;
        }

        public bool Pesquisar(string matricula)
        {
            Elemento aux = cabecaFila;
            Elemento ant = null;

            while (aux != null && matricula != aux.Valor.Matricula)
            {
                ant = aux;
                aux = aux.Proximo;
            }

            if (matricula == aux.Valor.Matricula)
                return true;

            return false;
        }

        public void Eliminar(string matricula)
        {
            Elemento aux = cabecaFila;
            Elemento ant = null;

            while (aux != null && matricula != aux.Valor.Matricula)
            {
                ant = aux;
                aux = aux.Proximo;
            }

            if (ant == null)
            {
                cabecaFila = cabecaFila.Proximo;
                return;
            }

            if (matricula == aux.Valor.Matricula)
                ant.Proximo = aux.Proximo;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Elemento aux = cabecaFila;

            while (aux != null)
            {
                res.Append(aux.Valor.ToString());
                aux = aux.Proximo;
            }
            return res.ToString();
        }
    }
}
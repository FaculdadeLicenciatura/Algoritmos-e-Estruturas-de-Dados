using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD{
    public class Conjunto {
        // c -> [3]->[4]->[5]->[8]
        // c -> []
        private Elemento cabeca;

        public Conjunto() { cabeca = null; }
        public void Insercao(int numero) {
            Elemento ant = cabeca, aux = cabeca;
            while (aux != null && numero > aux.Valor) {
                ant = aux;
                aux = aux.Proximo;
            }
            Elemento novo = new Elemento { Valor = numero, Proximo = aux };
            if (aux == null || numero != aux.Valor) {
                if (ant == aux)
                    cabeca = novo;
                else
                    ant.Proximo = novo;
            }
        }

        public void Remocao(int numero) {
            Elemento ant, aux;
            ant = aux = cabeca;
            if (cabeca != null) {
                if (cabeca.Valor == numero)
                    cabeca = cabeca.Proximo;
                while (aux != null && numero > aux.Valor) {
                    ant = aux;
                    aux = aux.Proximo;
                }
                if (aux != null && aux.Valor == numero) {
                    ant.Proximo = aux.Proximo;
                }
            }
        }

        public bool Pertence(int numero) {
            Elemento aux = cabeca;
            while (aux != null) {
                if (numero == aux.Valor) return true;
                aux = aux.Proximo;
            }
            return false;
        }

        public void Insercao(params int[] valores) {
            foreach (int n in valores) {
                Insercao(n);
            }
        }

        public override string ToString() {
            StringBuilder res = new StringBuilder();
            Elemento aux = cabeca;
            res.Append("{");
            while (aux != null) {
                res.Append(string.Format(" {0} ", aux.Valor));
                aux = aux.Proximo;
            }
            res.AppendLine("}");
            return res.ToString();
        }
    }
}

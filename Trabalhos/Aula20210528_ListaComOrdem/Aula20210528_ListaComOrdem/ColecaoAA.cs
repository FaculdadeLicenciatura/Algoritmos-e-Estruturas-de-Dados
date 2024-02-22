using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20210528_ListaComOrdem {
    public class ColecaoAA {
        private Elemento cabeca;

        public void InsereNovo(AntigoAluno antigoAluno) {
            Elemento ant, aux;
            ant = aux = cabeca;

            while (aux != null && antigoAluno.Numero > aux.Valor.Numero) {
                ant = aux;
                aux = aux.Proximo;
            }
            Elemento novo = new Elemento { Valor = antigoAluno, Proximo = aux };
            if (ant == aux)
                cabeca = novo;
            else
                ant.Proximo = novo;
        }

        public override string ToString() {
            StringBuilder res = new StringBuilder();
            Elemento aux = cabeca;
            while (aux != null) {
                res.AppendLine(aux.ToString());
                aux = aux.Proximo;
            }
            return res.ToString();
        }
    }
}

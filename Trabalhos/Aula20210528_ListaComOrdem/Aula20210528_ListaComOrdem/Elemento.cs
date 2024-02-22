using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20210528_ListaComOrdem {
    public class Elemento {
        private AntigoAluno valor;
        private Elemento proximo;

        public Elemento() { }

        public Elemento Proximo { get => proximo; set => proximo = value; }
        internal AntigoAluno Valor { get => valor; set => valor = value; }

        public override string ToString() {
            return valor.ToString();
        }
    }
}

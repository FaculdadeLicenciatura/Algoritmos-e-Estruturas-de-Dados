using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20210611_HashTable {
    class NossaHashListasColisao {
        private ListaLigadaPessoa[] tabela;
        /*
         * th: função x ondeGuardo
         * função: h(numero) = (numero % 5)
         */

        public NossaHashListasColisao() {
            tabela = new ListaLigadaPessoa[5];
            for (int i = 0; i < 5; i++) {
                // aqui iniciar array
                tabela[i] = new ListaLigadaPessoa();
            }
        }
        // h(numero) = (numero % 5)
        private int Hash(int numero) {
            return numero % 5;
        }
        public void Inserir(int numero, string nome) {
            int pos = Hash(numero);
            Pessoa nova = new Pessoa {
                Numero = numero,
                Nome = nome
            };
            tabela[pos].Adicionar(nova);
        }
    }
}

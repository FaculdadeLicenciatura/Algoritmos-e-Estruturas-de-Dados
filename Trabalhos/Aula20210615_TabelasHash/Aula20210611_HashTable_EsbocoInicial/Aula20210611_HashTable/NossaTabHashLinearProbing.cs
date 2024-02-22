using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20210611_HashTable {
    public class NossaTabHashLinearProbing {
        const int tam = 11;
        private Pessoa[] tabela;
        /*
         * th: função x ondeGuardo
         * função: h(numero) = (numero % 5)
         */

        public NossaTabHashLinearProbing() {
            tabela = new Pessoa[tam];
            //for (int i = 0; i < 5; i++) {
            //    // aqui iniciar array
            //    tabela[i] = null;
            //}
        }
        // h(numero) = (numero % 5)
        private int Hash(int numero) {
            return numero % tam;
        }

        /*
         * 'AA-11-12'
         * chave[0] = 'A' = 65
         * chave[1] = 'A' = 65
         * chave[2] = '-' = 45
         *  (...)
         */ 
        public int Hash(string chave) {
            int somatorio = 0;
            for (int i = 0; i < chave.Length; i++) {
                //Console.WriteLine("{0} -> {1}", chave[i], Convert.ToInt32(chave[i]));
                somatorio += Convert.ToInt32(chave[i]);

            }
            //Console.WriteLine("chave = '{0}' somatorio = {1}, hash = {2}", chave, somatorio, somatorio % tam);
            return this.Hash(somatorio);
        }

        public bool Inserir(int numero, string nome) {
            int pos = Hash(numero);
            Pessoa nova = new Pessoa {
                Numero = numero,
                Nome = nome
            };
            // e a posição, está livre?
            if (tabela[pos] != null) {
                // procurar próxima posicao livre (se existir)

                return false;
            } else {
                tabela[pos] = nova;
                return true;
            }
        }

        public bool InserirPorNome(int numero, string nome) {
            int pos = Hash(nome);
            Pessoa nova = new Pessoa {
                Numero = numero,
                Nome = nome
            };
            // e a posição, está livre?
            if (tabela[pos] != null) {
                // cálculo posicao livre (se existir)

                return false;
            } else {
                tabela[pos] = nova;
                return true;
            }
        }

        public void RemoverPessoa(int numero) {
            int pos = Hash(numero);
            // procura
            // se encontrei removo
        }

        public override string ToString() {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < tam; i++) {
                res.AppendLine(
                    tabela[i] != null ? tabela[i].ToString() : " * vazio * "
                    ); 
            }
            return res.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TPC5
{
    class HashListColisao
    {
        private ListaLigadaAuto[] tabela;
        /*
         * th: função x ondeGuardo
         * função: h(numero) = (numero % 5)
         */

        public HashListColisao()
        {
            tabela = new ListaLigadaAuto[5];
            for (int i = 0; i < 5; i++)
            {
                tabela[i] = new ListaLigadaAuto();
            }
        }
        private int Hash(int numero)
        {
            return numero % 5;
        }
        public int Hash(string chave)
        {
            int somatorio = 0;
            for (int i = 0; i < chave.Length; i++)
            {

                somatorio += Convert.ToInt32(chave[i]);

            }
            return this.Hash(somatorio);
        }

        public void Inserir(string numero, string marca, string matricula, string modelo)
        {
            int pos = Hash(numero);
            Auto nova = new Auto
            {
                Matricula = matricula,
                Marca = marca,
                Modelo = modelo,
                Numero = numero,
            };
            tabela[pos].CriarRegisto(nova);
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < tabela.Length; i++)
            {
                res.Append("Posição " + i + ":");
                res.AppendLine(tabela[i] != null ? tabela[i].ToString() : " * vazio * ");
            }
            return res.ToString();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TPC5
{
    public class HashLinearProbing
    {
        const int tam = 8;
        private Auto[] tabela;
        /*
         * th: função x ondeGuardo
         * função: h(numero) = (numero % 5)
         */

        public HashLinearProbing()
        {
            tabela = new Auto[tam];
        }
        private int Hash(int numero)
        {
            return numero % tam;
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

        public bool Inserir(string numero, string marca,string matricula,string modelo)
        {
            int pos = Hash(matricula);
            Auto nova = new Auto
            {
                Matricula = matricula,
                Marca = marca,
                Modelo = modelo,
                Numero = numero,
              
            };
            if (tabela[pos] != null)
            {
                return false;
            }
            else
            {
                tabela[pos] = nova;
                return true;
            }
        }

        public bool InserirPorNome(string numero, string marca, string matricula, string modelo)
        {
            int pos = Hash(marca);
            Auto nova = new Auto
            {
                Matricula = matricula,
                Marca = marca,
                Modelo = modelo,
                Numero = numero,
            };
            if (tabela[pos] != null)
            {
                return false;
            }
            else
            {
                tabela[pos] = nova;
                return true;
            }
        }

        public void Remover(string matricula)
        {
            int pos = Hash(matricula);
            Console.WriteLine("\nO registo com matricula: " + tabela[pos].Matricula + " ,Marca: "+ tabela[pos].Marca + " ,Modelo: " + tabela[pos].Modelo + " ,Foi removido com sucesso.");
            tabela[pos] = null;
            
        }
        public void Procurar(string matricula)
        {
            bool exist = false;
            int posfound = 0;
            for(int j = 0;j < tam;j++)
            {
                if(tabela[j] != null)
                {
                    if (tabela[j].Matricula == matricula)
                    {
                        exist = true;
                        posfound = j;
                    }
                }
                
            }
            if (exist == true)
            {
                Console.WriteLine("\nFoi encontrado o registo pretendido: " + tabela[posfound]);
            }
            else
            {
                Console.WriteLine("\nNão foi encontrado nenhum registo com a matricula dada");
            }
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < tam; i++)
            {
                res.Append("Posição " + i + ":");
                res.AppendLine(tabela[i] != null ? tabela[i].ToString() : " * vazio * ");
            }
            return res.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TPC5
{
    internal class ListaLigadaAuto
    {
        private Elemento cabecaFila;

        public ListaLigadaAuto() { cabecaFila = null; }

        public void CriarRegisto(Auto automovel)
        {
            Elemento novo = new Elemento { Automovel = automovel, Proximo = null };
            Elemento aux = cabecaFila;
            Elemento ant = null;

            while (aux != null && aux.Automovel.Matricula != null)
            {
                ant = aux;
                aux = aux.Proximo;
            }

            if (ant == null)
            {
                novo.Proximo = cabecaFila;
                cabecaFila = novo;
            }
            else
            {
                novo.Proximo = ant.Proximo;
                ant.Proximo = novo;
            }
        }
        public void Procurar(string matricula)
        {
            int posfound = 0;
            List<Elemento> ls = new List<Elemento>();
            Elemento aux = cabecaFila;
            bool exist = false;
            while (aux != null)
            {
                ls.Add(aux);
                aux = aux.Proximo;
            }
            for (int j = 0; j < ls.Count; j++)
            {
                if (ls[j] != null)
                {
                    if (ls[j].Automovel.Matricula == matricula)
                    {
                        posfound = j;
                        exist = true;
                    }
                }

            }
            if (exist == true)
            {
                Console.WriteLine("\nFoi encontrado o registo pretendido: " + ls[posfound].Automovel.ToString());
            }
            else
            {
                Console.WriteLine("\nNão foi encontrado nenhum registo com a matricula dada");
            }
        }
        public void RemoverRegisto(string matricula)
        {
            Elemento aux = cabecaFila;
            Elemento ant = null;

            while (aux != null && matricula != aux.Automovel.Matricula)
            {
                ant = aux;
                aux = aux.Proximo;
            }
            if (ant == null)
            {
                cabecaFila = null;
                return;
            }      
            if (matricula == aux.Automovel.Matricula)
            {
                ant.Proximo = aux.Proximo;
            }
                
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Elemento aux = cabecaFila;

            while (aux != null)
            {
                res.AppendLine(aux.Automovel.ToString());
                aux = aux.Proximo;
            }
            return res.ToString();
        }
    }
}

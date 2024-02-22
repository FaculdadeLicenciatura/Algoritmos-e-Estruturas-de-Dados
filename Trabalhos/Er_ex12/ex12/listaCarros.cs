using System;
using System.Collections.Generic;
using System.Text;

namespace ex12
{
    class listaCarros
    {
        private Elemento topo;

        public listaCarros() { topo = null; }
        public void adecionar(carro novo)
        {
            Elemento nova = new Elemento { Valor = novo, Proximo = null };
            if (topo != null)
            {
                nova.Proximo = topo;
            }
            topo = nova;
        }

        public string procurar(string matricula)
        {
            Elemento aux = topo;
            while (aux != null)
            {
                if (aux.Valor.Matricula == matricula)
                {
                    return aux.Valor.ToString();
                }
                aux = aux.Proximo;
            }
            return "Nao existem carros com esta matricula";
        }

        public bool procurar2(string matricula)
        {
            Elemento aux = topo;
            while (aux != null)
            {
                if (aux.Valor.Matricula == matricula)
                {
                    return true;
                }
                aux = aux.Proximo;
            }
            return false;
        }

        public int length()
        {
            Elemento aux = topo;
            int count = 0;
            while(aux!= null)
            {
                count++;
                aux = aux.Proximo;
 
            }
            return count;
        }

        public void Eliminar(string matricula)
        {
            Elemento ant = null;
            Elemento aux = topo;
            while (aux != null && matricula != aux.Valor.Matricula)
            {
                ant = aux;
                aux = aux.Proximo;
            }
            if (matricula == aux.Valor.Matricula)
            {
                ant.Proximo = aux.Proximo;
            }
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Elemento aux = topo;
            int pos = 0;
           
            while (aux != null)
            {
                
                res.AppendLine(aux.Valor.ToString());
                pos++;
                aux = aux.Proximo;
               
               
            }
            return res.ToString();
        }
    }
}

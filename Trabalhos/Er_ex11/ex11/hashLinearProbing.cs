using System;
using System.Collections.Generic;
using System.Text;

namespace ex11
{
    class hashLinearProbing
    {
        const int tam=11;
        private carro[] tabela = new carro[tam];

        public hashLinearProbing()
        {

        }

        public int Hash(string matricula)
        {
            int valor = 0;
            for(int i =0;i< matricula.Length; i++)
            {
                valor += Convert.ToInt32(matricula[i]);
                
            }
            return valor % tam;

        }

        public void Inserir(carro carro)
        {
            int pos = Hash(carro.Matricula);
            if (tabela[pos] == null)
            {
                tabela[pos] = carro;
            }
            else
            {
                for(int i = pos+1; i<tam; i++)
                {
                    if (tabela[i] == null)
                    {
                        tabela[i] = carro;
                        break;
                    }
                    if (i == tam-1)
                    {
                        i = -1;
                    }
                    if (i == pos)
                    {
                        Console.WriteLine("Array cheio");
                        break;
                    }
                }
            }
           
        }

        public string Procurar(string matricula)
        {
            for (int i = 0; i < tam; i++) {
                if (tabela[i].Matricula == matricula)
                {
                    return tabela[i].ToString();
                }
                
            }
            return "Valor nao existe"; 
           
        }

        public string Eliminar(string matricula)
        {
            for (int i = 0; i < tam; i++)
            {
                if (tabela[i] != null)
                {
                    if (tabela[i].Matricula == matricula)
                    {
                        tabela[i] = null;
                        return "Removido com sucesso";
                    }
                }
                

            }
            return "Valor nao existe";
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            int pos = 0;
            foreach(carro carro in tabela)
            {
                if (carro != null)
                {
                    res.AppendLine("Posicao " + Convert.ToString(pos) + " -->" + carro.ToString());

                    
                }
                else
                {
                    res.AppendLine("Posicao " + Convert.ToString(pos) + " -->");
                }
                pos++;
            }

            return res.ToString();
        }

    }
}

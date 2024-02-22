using System;
using System.Collections.Generic;
using System.Text;

namespace ex12
{
    class hashlistacolisoes
    {
        const int tam = 11;
        private listaCarros[] tabela = new listaCarros[tam];

        public hashlistacolisoes()
        {
            for (int i = 0; i < tam; i++)
            {
                // aqui iniciar array
                tabela[i] = new listaCarros();
            }
        }

        private int Hash(string matricula)
        {
            int valor = 0;
            for (int i = 0; i < matricula.Length; i++)
            {
                valor += Convert.ToInt32(matricula[i]);

            }
           //Console.WriteLine(valor % tam);
            return valor % tam;
        }

        public void Inserir(carro novo)
        {
            
            int pos = Hash(novo.Matricula);
            if (tabela[pos].procurar2(novo.Matricula)==false)
            {
                tabela[pos].adecionar(novo);
            }
            else
            {
                Console.WriteLine("carro ja existente");
            }
            
        }

        public string procurar(string matricula)
        {
            int pos = Hash(matricula);
            string res = tabela[pos].procurar(matricula);
            return res;
        }

        public bool procurar2(string matricula)
        {
            int pos = Hash(matricula);
            bool res = tabela[pos].procurar2(matricula);
            return res;
        }

        public void Remover(string matricula)
        {
            int pos = Hash(matricula);
            tabela[pos].Eliminar(matricula);
        }
        public override string ToString()
        {
                StringBuilder res = new StringBuilder();
                int nlista = 0;
                foreach (listaCarros lista in tabela)
                {
                        if (lista.length() == 0)
                        {
                            res.AppendLine("Posicao " + nlista + "--> ");
                        }
                        else
                        {
                            res.AppendLine("Posicao " + Convert.ToString(nlista) + " -->");
                            res.Append(lista.ToString());
                    
                        }
                        nlista++;


                
                    
                }
                return res.ToString();
        }
    }
}

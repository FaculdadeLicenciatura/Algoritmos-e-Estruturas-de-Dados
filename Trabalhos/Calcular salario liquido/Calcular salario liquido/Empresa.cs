using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_salario_liquido
{
    class Empresa
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private Trabalhador[] lista;

        public Trabalhador[] Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public Empresa (string nomeValue)
        {
            Nome = nomeValue;
        }
        public int OrdenarString(string a, string b)
        {
            int f = 0;
            for (int letra = 0; letra < a.Length; letra++)
            {
                if (a.Length > letra && b.Length > letra)
                {
                    if (a[letra] < b[letra])
                    {
                        f = 1;
                        break;
                        //palavra a primeiro
                    }
                    if (a[letra] > b[letra])
                    {
                        f = -1;
                        break;
                        //palavra a depois
                    }
                    if (a[letra] == b[letra])
                    {
                        f = 0;
                        //palavra igual
                    }
                }
            }

            return f;
        }



        public Trabalhador[] OrdenarNomes()
        {
            for (int nome = 0; nome < Lista.Length; nome++)
            {
                for (int nomes = Lista.Length - 1; nomes > nome; nomes--)
                {
                    if (OrdenarString(Lista[nome].Nome, Lista[nomes].Nome) < 0)
                    {
                        Trabalhador aux = Lista[nome];
                        Lista[nome] = Lista[nomes];
                        Lista[nomes] = aux;

                    }
                }
            }
            return Lista;
        }

        public Trabalhador[] OrdenarDependentes()
        {
            for (int i = 1; i < Lista.Length; i++)
            {
                for (int j = i - 1; j >= 0 && j < i; j--)
                {
                    if (Lista[i].Dependentes < Lista[j].Dependentes)
                    {
                        Trabalhador aux = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = aux;

                        int auxint = i;
                        i = j;
                        j = auxint;
                        break;
                    }
                    else
                    {
                        if (Lista[i].Dependentes == Lista[j].Dependentes)
                        {
                            if (OrdenarString(Lista[i].Nome, Lista[j].Nome)> 0)
                            {
                                Trabalhador aux = Lista[i];
                                Lista[i] = Lista[j];
                                Lista[j] = aux;

                                int auxint = i;
                                i = j;
                                j = auxint;
                            }
                        }
                    }
                   
                }
            }
            return Lista;
        }
    }
}

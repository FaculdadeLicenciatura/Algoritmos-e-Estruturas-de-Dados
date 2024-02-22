using System;
using System.Text;

namespace Automovel_TabelaHash
{
    public class TabHashListaColisoes
    {
        const int tamanho = 11;
        private ListaLigadaAutomovel[] tabela;

        public TabHashListaColisoes()
        {
            tabela = new ListaLigadaAutomovel[tamanho];
            for (int i = 0; i < tamanho; i++)
                tabela[i] = new ListaLigadaAutomovel();
        }

        private int Hash(string matricula)
        {
            int somatorio = 0;
            for (int i = 0; i < matricula.Length; i++)
                somatorio += Convert.ToInt32(matricula[i]);

            return somatorio % tamanho;
        }

        public void Inserir(string matricula, string marca, string modelo, string numQuadro)
        {
            int posicao = Hash(matricula);

            Automovel novo = new Automovel {
                Matricula = matricula, Marca = marca,
                Modelo = modelo, NumQuadro = numQuadro
            };

            tabela[posicao].Adicionar(novo);
        }

        public bool Procurar(string matricula)
        {
            int posicao = Hash(matricula);

            if (tabela[posicao].Pesquisar(matricula))
                return true;

            return false;
        }

        public void Remover(string matricula)
        {
            int posicao = Hash(matricula);

            tabela[posicao].Eliminar(matricula);
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < tamanho; i++) {
                res.Append("\nPosição: " + i + " --> ");
                res.Append(tabela[i] != null ? tabela[i].ToString() : "* vazia *");
            }
            return res.ToString();
        }
    }
}
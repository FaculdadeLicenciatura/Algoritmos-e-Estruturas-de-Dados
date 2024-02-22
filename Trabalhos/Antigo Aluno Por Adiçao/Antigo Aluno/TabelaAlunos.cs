using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antigo_Aluno
{
    public class TabelaAlunos
    {
        private List<AntigoAluno> bd;

        public TabelaAlunos()
        {
            bd = new List<AntigoAluno>();
        }

        //alinia 1
        public void Registo(int numeroAntigoAluno, string nomeAntigoAluno, DateTime DatenAntigoAluno, curso CursoAntigoAluno)
        {
            AntigoAluno novo = new AntigoAluno
            {
                Numero = numeroAntigoAluno,
                Nome = nomeAntigoAluno,
                Datan = DatenAntigoAluno,
                Curso = CursoAntigoAluno
            };
            if (!bd.Contains(novo))
                bd.Add(novo);
        }

        //alinia 2
        public AntigoAluno[] Devolver()
        {
            AntigoAluno[] lista = new AntigoAluno[bd.Count];
            for (int i = 0; i < bd.Count; i++)
            {
                lista[i] = bd[i];
            }
            return lista;
        }

        //alinia 3
        public AntigoAluno Remover(int numeroAntigoAluno)
        {
            AntigoAluno resultado = bd.Find(a => a.Numero == numeroAntigoAluno);
            bd.Remove(resultado);
            return resultado;
        }

        //alinia 5
        public AntigoAluno[] Curso(curso Curso)
        {
            List<AntigoAluno> aux = new List<AntigoAluno>();
            for (int i = 0; i < bd.Count; i++)
            {
                if (bd[i].Curso == Curso)
                {
                    aux.Add(bd[i]);

                }
            }
            AntigoAluno[] lista = new AntigoAluno[aux.Count];
            for (int i = 0; i < aux.Count; i++)
            {
                lista[i] = aux[i];
            }

            return lista;
        }


        //alinia 4
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < bd.Count; i++)
            {
                res.AppendLine(bd[i].ToString());
            }
            return res.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antigo_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            TabelaAlunos t = new TabelaAlunos();
            #region alinia 1
            t.Registo(13, "Nelo Chapeiro", new DateTime(2010, 11, 4), curso.Contabilidade);
            t.Registo(12, "Joaquim Alberto", new DateTime(2010, 10, 3), curso.Desporto);
            t.Registo(11, "Samuel Massas", new DateTime(2010, 9, 24), curso.Contabilidade);
            t.Registo(12, "Cristiano Ronaldo", new DateTime(2010, 11, 1), curso.Desporto);
            t.Registo(9, "Bruno Carvalho", new DateTime(2010, 11, 1), curso.Desporto);
            #endregion
            #region alinia 3
            t.Remover(9);
            #endregion
            #region alinia 2
            Console.WriteLine("--TODOS--");
            for (int i = 0; i < t.Devolver().Length; i++)
            {
                Console.WriteLine(t.Devolver()[i]);
            }
            #endregion
            #region alinia 4
            Console.WriteLine("--TODOS 2--");
            Console.WriteLine(t.ToString());
            #endregion
            #region alinia 5
            Console.WriteLine("--CURSO--");
            for (int i = 0; i < t.Curso(curso.Contabilidade).Length; i++)
            {
                Console.WriteLine(t.Curso(curso.Contabilidade)[i]);
            }
            #endregion

        }
    }
}
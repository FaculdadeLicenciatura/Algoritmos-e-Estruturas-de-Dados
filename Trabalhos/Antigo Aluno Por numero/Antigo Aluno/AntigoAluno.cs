using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antigo_Aluno
{
    public enum curso
    {
        Desporto,
        Solicitadoria,
        TreinoDesportivo,
        Contabilidade
    }
    public class AntigoAluno
    {

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private DateTime datan;

        public DateTime Datan
        {
            get { return datan; }
            set { datan = value; }
        }

        private curso curso;

        public curso Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public override string ToString()
        {
            return string.Format("{0,10}, {1}, {2}, {3}", Numero, Nome,Datan.ToShortDateString(),Curso);
        }

        // Dupla entrada primary key
        public override bool Equals(object obj)
        {
            if (obj != null && obj is AntigoAluno)
            {
                return ((AntigoAluno)obj).Numero == this.Numero;
            }
            else return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20210528_ListaComOrdem {
    class Program {
        static void Main(string[] args) {
            ColecaoAA alunos = new ColecaoAA();
            alunos.InsereNovo(new AntigoAluno { Numero = 111, Nome = "Primeiro" });
            alunos.InsereNovo(new AntigoAluno { Numero = 333, Nome = "Terceiro" });

            Console.WriteLine(alunos);

            Console.WriteLine("-------------");
            alunos.InsereNovo(new AntigoAluno { Numero = 222, Nome = "Segundo" });
            Console.WriteLine(alunos);
        }
    }
}

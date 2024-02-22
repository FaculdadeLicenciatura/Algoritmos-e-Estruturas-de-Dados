using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD
{
    public class Program
    {
        public static int param(string pat, string txt)
        {
            int M = pat.Length;
            int N = txt.Length;

            for (int i = 0; i <= N - M; i++)
            {
                int j;
                for (j=0; j<M; j++)
                {
                    if (txt[(i  +  j)]  != pat[(j)])
                        break;
                    if (j == M) return i;
                }
            }
            return N;
        }
        static void Main(string[] args)
        {
            Conjunto c = new Conjunto();
            Console.WriteLine("caso 1: conj vazio");
            Console.WriteLine(c);

            Console.WriteLine("caso 2: conj um elemento");
            c.Insercao(3);
            Console.WriteLine(c);

            Console.WriteLine("caso 3: conj varios e repetidos elemento");
            c.Insercao(8);
            c.Insercao(5);
            c.Insercao(4);
            c.Insercao(4);
            Console.WriteLine(c);

            Console.WriteLine("caso 4: insercao multipla, param");
            c.Insercao(1, 2, 6);
            Console.WriteLine(c);

            Console.WriteLine("Pertence {0} a c = {1}", 7, c.Pertence(7));
            Console.WriteLine("Pertence {0} a c = {1}", 8, c.Pertence(8));

            Console.WriteLine("caso 5: remocao valor que existe");
            c.Remocao(8);
            Console.WriteLine(c);

            Console.WriteLine("caso 6: remocao valor que nao existe");
            c.Remocao(7);
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}

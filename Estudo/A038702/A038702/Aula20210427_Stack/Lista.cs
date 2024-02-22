using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20210427_Stack {
    class Lista
    {
        private Elemento lista;
        private int Total = 0;

        public Lista() { lista = new Elemento();
            for (int i = 0; i < 6; i++)
            {
                lista.Proximo = new Elemento();
            }
        }


        public void Add(int valor) {
            Elemento elemento = new Elemento();
            if(lista.Valor == -1)
            {
                lista.Valor = valor;
            }
            else
            {
                elemento = lista.Proximo ;
                try
                {
                    while (elemento.Valor != -1)
                    {
                        Console.WriteLine(elemento.Valor);
                    }
                }
                catch 
                {
                    lista.Valor = valor;
                    Console.WriteLine(elemento.Valor);
                }
            }
            /*elemento = lista;
            elemento = lista.Proximo;
            Console.WriteLine(elemento.Valor);

            Console.WriteLine(elemento.Valor);
            //if (elemento.Valor == -1)
            {
                elemento.Valor = valor;
            }
            while (elemento.Valor != -1)
            {
                if (elemento.Valor == -1)
                {
                    elemento.Valor = valor;
                }
                elemento = lista.Proximo;
                //Console.WriteLine(elemento.Valor);
            }*/
        }

        public int Get(int valor) { return 0; }

        public int Pop() { return 0; }

        public Elemento Reverse() { return null; }

        public override string ToString()
        {
            return null;
        }
    }
}

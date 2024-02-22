using System;
using System.IO;
using System.Collections.Generic;

namespace teste_cSharp_console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conjunto conjunto = new Conjunto();       
            Console.WriteLine("\n Primeira lista");
            Console.WriteLine("\n Quantos valores deseja adicionar á lista?");
            int contador = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Valores:");
            for (int i = 0; i < contador; i++)
            {
                int numero = Int32.Parse(Console.ReadLine());
                conjunto.adicionar(numero);            
            }
            Console.WriteLine("\n Lista");            
            conjunto.imprimir();
            Console.WriteLine("\n Lista ordenada");
            conjunto.imprimirOrdenado();
            
            Conjunto conjunto2 = new Conjunto();       
            Console.WriteLine("\n Segunda lista");
            Console.WriteLine("\n Quantos valores deseja adicionar á lista?");
            int contador2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Valores:");
            for (int i = 0; i < contador2; i++)
            {
                int numero = Int32.Parse(Console.ReadLine());
                conjunto2.adicionar(numero);            
            }
            Console.WriteLine("\n Segunda Lista");            
            conjunto2.imprimir();
            Console.WriteLine("\n Segunda Lista ordenada");
            conjunto2.imprimirOrdenado();

            Conjunto uniaoConjuntos = new Conjunto();
            foreach(int element in conjunto.devolver())
            {
                uniaoConjuntos.adicionar(element);
            }
            foreach(int element in conjunto2.devolver())
            {
                uniaoConjuntos.adicionar(element);
            }
            Console.WriteLine("\n União das duas listas");
            Console.WriteLine(uniaoConjuntos.ToString());
            Console.WriteLine("\n União das duas listas ordenadas");
            uniaoConjuntos.imprimirOrdenado();
        }
        

    }
    class Conjunto
    {
        LinkedList<int> lista = new LinkedList<int>();
        public void adicionar(int numero)
        {
                if (!lista.Contains(numero))
                {
                    lista.AddLast(numero);
                }
        }
        
        public void imprimir()
        {
            foreach(int elemento in lista)
            {
                Console.WriteLine(" " + elemento);
            }
        }
        public void imprimirOrdenado()
        {
            int[] vetor = devolver();
            if(vetor!=null && vetor.Length > 1)
            {
                for(int i=0 ; i<vetor.Length; i++)
                {
                    int min = i;
                    for(int j=i+1; j<vetor.Length; j++)
                    {
                        if (vetor[j] < vetor[min])
                        {
                            min = j;
                        }
                    }
                    int aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }
                
            foreach (int elemento in vetor)
            {
                Console.WriteLine(" " + elemento);
            }
        }

        public int[] devolver()
        {
            int[] myArr = new int[lista.Count];

            lista.CopyTo(myArr, 0);

            return myArr;
        }

        public string ToString() {
            string texto="";
            foreach (int elemento in lista)
            {
                texto += elemento + ",\n" ;
            }
            return texto;

        }

    }
}

using System;
using System.Collections;

namespace TPC5
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto c1 = new Auto();
            c1.Create("150", "Ford", "23-ZZ-99", "Focus");

            HashLinearProbing hashbd = new HashLinearProbing();
            hashbd.Inserir("100","BMW","AA-XZ-23","i5");
             hashbd.Inserir("140", "Mercedes", "CC-TR-18", "CLS");
             hashbd.Inserir("120", "Ferrari", "BB-XX-06", "La Ferrari");
             hashbd.Inserir("160", "Audi", "DD-TZ-81", "rs6");
            Console.WriteLine(hashbd.ToString()); 

            hashbd.Procurar("AAAAA");
            hashbd.Procurar("CC-TR-18");

            hashbd.Remover("BB-XX-06");
            hashbd.Procurar("BB-XX-06");


            ListaLigadaAuto linked = new ListaLigadaAuto();
            linked.CriarRegisto(c1);
            linked.Procurar("23-ZZ-99");
            linked.Procurar("55-DD-22");
            //linked.RemoverRegisto("23-ZZ-99");

            Console.WriteLine(linked.ToString());

            HashListColisao hashcoli = new HashListColisao();
            hashcoli.Inserir("150", "Ford", "23-ZZ-99", "Focus");
            hashcoli.Inserir("150", "Fiat", "55-DD-22", "500");

            Console.WriteLine(hashcoli.ToString());


            Console.ReadLine();

        }
    }
}

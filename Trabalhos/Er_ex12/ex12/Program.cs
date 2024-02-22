using System;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {

            carro c1 = new carro("AA-15-45","Mercedes","45", "5");
            carro c2 = new carro("GM-10-45", "BMW", "45", "5");
            carro c3 = new carro("TI-30-10", "FERRARI", "45", "5");
            carro c4 = new carro("ZA-30-25", "CITROEN", "45", "5");
            carro c5 = new carro("TU-90-90", "Mercedes", "45", "5");

            
            hashlistacolisoes t1 = new hashlistacolisoes();

            t1.Inserir(c1);
            t1.Inserir(c2);
            t1.Inserir(c3);
            t1.Inserir(c4);
            t1.Inserir(c5);



            Console.WriteLine(t1.procurar("ZA-30-25"));

            //t1.Remover("ZA-30-25");

            Console.WriteLine(t1.ToString());
        }
    }
}

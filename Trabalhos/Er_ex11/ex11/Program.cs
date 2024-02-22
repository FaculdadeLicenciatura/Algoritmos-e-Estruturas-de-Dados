
using System;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            carro c1 = new carro("AA-12-15", "Citroen", "A1", "5");
            carro c2 = new carro("ZB-50-90", "BMW", "A4", "5");
            carro c3 = new carro("AZ-30-15", "MERCEDES", "10", "5");
            carro c4 = new carro("TY-05-29", "OPEL", "30", "5");
            carro c5 = new carro("CC-10-17", "Citroen", "A1", "5");
            carro c6 = new carro("DF-50-50", "BMW", "A4", "5");
            carro c7 = new carro("HM-30-05", "MERCEDES", "10", "5");
            carro c8 = new carro("TY-05-29", "OPEL", "30", "5");
            carro c9 = new carro("TY-06-30", "OPEL", "30", "5");

            hashLinearProbing hash = new hashLinearProbing();
            hash.Inserir(c1);
            hash.Inserir(c2);
            hash.Inserir(c3);
            hash.Inserir(c4);
            hash.Inserir(c5);
            hash.Inserir(c6);
            hash.Inserir(c7);
            hash.Inserir(c8);
            hash.Inserir(c9);


            hash.Eliminar("HM-30-05");

            //Console.WriteLine(hash.Procurar("ZB-50-90"));



            Console.WriteLine(hash.ToString());
        }
    }
}

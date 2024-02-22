using System;

namespace Automovel_TabelaHash
{
    class Program
    {
        static void Main(string[] args)
        {
            TabHashListaColisoes th = new TabHashListaColisoes();
            string matrProcurada = "14-15-KQ";

            th.Inserir("12-BH-20", "Volkswagen", "Polo", "9BWHE21JX24060960");
            th.Inserir("12-BH-22", "Volkswagen", "Polo", "9BWHE21JX24060960");
            th.Inserir("78-TH-19", "Volkswagen", "T-Cross", "5PWHP45JY84000641");
            th.Inserir("IB-10-63", "BMW", "i3", "6PBHE31LX90140990");
            th.Inserir("14-15-KQ", "Audi", "A1", "5RAHB10UX44901060");
            th.Inserir("IR-44-59", "Tesla", "Model X", "1ETHA96GY48000943");
            th.Inserir("OL-07-12", "Ford", "Puma", "4OFHL32JY84202940");
            Console.WriteLine("Tabela de Hash Original:\n" + th);

            if (th.Procurar(matrProcurada))
                Console.WriteLine("\nO automóvel com a matrícula {0} está registado.", matrProcurada);
            else
                Console.WriteLine("\nO automóvel com a matrícula {0} não está registado.", matrProcurada);

            th.Remover(matrProcurada);
            Console.WriteLine("\nTabela de Hash Modificada (remoção do automóvel com a matrícula {0}):\n" + th, matrProcurada);
            
            Console.ReadKey();
        }
    }
}
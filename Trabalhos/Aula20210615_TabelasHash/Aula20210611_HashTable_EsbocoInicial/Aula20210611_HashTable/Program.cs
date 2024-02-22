using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20210611_HashTable {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine(NossaTabHashLinearProbing.Hash("AA-11-12"));
            //Console.WriteLine(NossaTabHashLinearProbing.Hash("11-RT-67"));
            //Console.WriteLine(NossaTabHashLinearProbing.Hash(111));
            //Console.WriteLine(NossaTabHashLinearProbing.Hash(200));
            //Console.WriteLine(NossaTabHashLinearProbing.Hash(222));
            //Console.WriteLine(NossaTabHashLinearProbing.Hash(444));
            //Console.WriteLine(NossaTabHashLinearProbing.Hash(504));
            //Console.WriteLine(NossaTabHashLinearProbing.Hash(303));

            NossaTabHashLinearProbing bd = new NossaTabHashLinearProbing();
            bd.Inserir(111, "Zeferino");
            bd.Inserir(200, "Saraiva");
            bd.Inserir(222, "Valentim");
            bd.Inserir(444, "Salomao");
            bd.Inserir(504, "Quim");
            Console.WriteLine(bd);
            Console.WriteLine();
            Console.WriteLine("---");
            Console.WriteLine();
            NossaTabHashLinearProbing bdnome = new NossaTabHashLinearProbing();
            bdnome.InserirPorNome(111, "Zeferino");
            bdnome.InserirPorNome(200, "Saraiva");
            bdnome.InserirPorNome(222, "Valentim");
            bdnome.InserirPorNome(444, "Salomao");
            bdnome.InserirPorNome(504, "Quim");
            Console.WriteLine(bdnome);

            NossaHashListasColisao db = new NossaHashListasColisao();

            Console.ReadKey();
        }
    }
}

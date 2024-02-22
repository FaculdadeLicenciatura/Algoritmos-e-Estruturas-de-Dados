using System;
using System.Collections.Generic;
using System.Text;

namespace TPC5
{
    internal class Auto
    {
        private string numero;
        private string marca;
        private string modelo;
        private string matricula;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Numero { get => numero; set => numero = value; }
        public void Create(string marca,string modelo,string matricula,string numero)
        {
            Marca = marca;
            Modelo = modelo;
            Matricula = matricula;
            Numero = numero;
    }
        public Auto() { }
        
        public override string ToString()
        {
            return string.Format("{0,5},{1},{3},{2}", Numero, Marca , Modelo , Matricula );
        }
    }
}

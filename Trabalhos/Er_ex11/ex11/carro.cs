using System;
using System.Collections.Generic;
using System.Text;

namespace ex11
{
    class carro
    {
        private string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string nquadro;

        public string Nquadro
        {
            get { return nquadro; }
            set { nquadro = value; }
        }

        public carro(string matriculaValue, string marcaValue, string modeloValue, string nquadroValue)
        {
            Matricula = matriculaValue;
            Marca = marcaValue;
            Modelo = modeloValue;
            Nquadro = nquadroValue;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(" " + Matricula + " / " + Marca + " / " + Modelo + " / " + Nquadro);
            


            return res.ToString();
        }



    }
}

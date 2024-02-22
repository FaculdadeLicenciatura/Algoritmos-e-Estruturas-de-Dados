using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_salario_liquido
{
    class Trabalhador
    {   
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int nif;

        public int Nif
        {
            get { return nif; }
            set { nif = value;}
        }

        private int dependentes;

        public int Dependentes
        {
            get { return dependentes; }
            set { dependentes = value; }
        }

        private bool defeciencia;

        public bool Defeciencia
        {
            get { return defeciencia; }
            set { defeciencia = value; }
        }

        private int titulares;

        public int Titulares
        {
            get { return titulares; }
            set { titulares = value; }
        }

        private double salarioBase;

        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }

        private double salarioliq;

        public double Salarioliq
        {
            get { return salarioliq; }
            set { salarioliq = value; }
        }

        public Trabalhador()
        {

        }
        public Trabalhador(string nomeValue, int nifValue, int dependentesValue, bool defecienciaValue, int titualeresValue, double salarioValue)
        {
            Nome = nomeValue;
            Nif = nifValue;
            Dependentes = dependentesValue;
            Defeciencia = defecienciaValue;
            Titulares = titualeresValue;
            SalarioBase = Math.Round(salarioValue,2);
        }

        double[] salarios = {659,686,718,739,814,922,1005,1065,1143,1225,1321,1424,1562,1711,1870,1977,
            2090,2218,2367,2535,2767,3104,3534,4118,4650,5194,5880,6727,7939,9560,11282,18854,20221,22749,25276};
        public int IndexarSalario()
        {
            int f=0;
            for (int k = 1; k < salarios.Count(); k++)
            {
                if (SalarioBase > salarios[34])
                {
                    f = 35;
                }
                else
                {
                    if (SalarioBase < salarios[0])
                    {
                        f = 0;
                    }
                    else
                    {
                        if (SalarioBase > salarios[k - 1] && SalarioBase <= salarios[k])
                        {
                            f = k;
                        }
                    }
                }
            }
            return f;
        }

        public override string ToString()
        {
            string defJ;
            if (Defeciencia)
            {
                defJ = "deficiente";
            }
            else
            {
                defJ = "sem deficiencia";
            }
            return (Nome + " | " + Nif + " | " + Dependentes + " | " + defJ + " | " + Titulares + " | " + SalarioBase + " euros | " + Salarioliq + " euros");
        }
    }
}

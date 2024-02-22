using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_salario_liquido
{
    class SalarioLiquido
    {
        private Trabalhador trabalhador;

        public Trabalhador Trabalhador
        {
            get { return trabalhador; }
            set { trabalhador = value; }
        }

        double taxa;
        public SalarioLiquido(Trabalhador trabalhadorValue)
        {
            Trabalhador = trabalhadorValue;
        }




        double[,] tabela = { 
            {0.0,0.1,4.2,7.3,8.2,10.4,11.6,12.4,13.5,14.5,15.6,16.6,17.7,19.1,20.5,21.5,22.5,23.5,24.5,25.5,26.5,27.8,29.4,30.5,32.3,33.3,34.3,36.3,37.3,39.3,40.3,41.3,42.3,43.1,44.1,45.1},
            {0.0,0.0,1.3,4.4,5.3,7.6,8.9,9.8,11.7,12.8,14.8,15.8,16.9,18.3,19.9,21.0,22.0,23.0,24.1,25.1,26.0,27.3,29.3,30.5,32.0,33.0,34.0,36.1,37.1,39.1,40.1,41.1,42.1,43.1,44.1,45.1,},
            {0.0,0.0,0.9,2.6,3.5,6.7,8.1,8.9,10.9,11.8,13.0,14.0,15.0,16.6,18.2,19.1,20.2,21.3,23.3,24.3,25.3,26.5,28.9,29.9,31.6,32.6,33.6,35.5,36.9,38.9,39.9,40.9,41.9,42.9,43.9,44.9,},
            {0.0,0.0,0.4,0.7,2.6,3.9,5.3,6.2,8.2,9.2,11.0,12.2,13.2,14.7,16.5,17.4,18.3,19.5,20.5,21.6,22.6,23.8,26.5,28.5,29.9,31.2,32.2,34.8,35.8,37.8,39.2,40.2,41.2,42.2,43.2,44.2 },
            {0.0,0.0,0.0,0.0,0.7,3.2,4.5,4.9,7.3,8.3,9.3,10.3,11.4,13.8,15.7,16.6,17.6,18.5,19.7,20.8,21.8,23.0,26.1,27.1,28.6,30.5,31.8,34.6,35.6,37.6,38.6,40.0,41.0,42.0,43.0,44.0},
            {0.0,0.0,0.0,0.0,0.0,1.3,3.2,4.0,5.5,6.5,8.4,9.5,10.5,12.0,13.9,14.9,16.8,17.9,18.8,20.0,21.0,22.2,25.7,26.7,28.2,29.2,30.1,34.4,35.4,37.4,38.4,39.4,40.4,41.6,42.8,43.8,} 
        };
        public double CalcularSalario()
        {
            int dependentes = Trabalhador.Dependentes;
            if(dependentes > 5)
            {
                dependentes = 5;
            }
              taxa = tabela[Trabalhador.Dependentes, Trabalhador.IndexarSalario()];
           
            return Trabalhador.SalarioBase - (Trabalhador.SalarioBase * (taxa/100));
        }
        
    }
}

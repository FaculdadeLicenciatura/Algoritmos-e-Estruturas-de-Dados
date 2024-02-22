namespace Automovel_TabelaHash
{
    public class Automovel
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

        private string numQuadro;
        public string NumQuadro
        {
            get { return numQuadro; }
            set { numQuadro = value; }
        }

        public Automovel() { }

        public Automovel(string matricula, string marca, string modelo, string numQuadro)
        {
            this.Matricula = matricula;
            this.Marca = marca;
            this.Modelo = modelo;
            this.NumQuadro = numQuadro;
        }

        public override string ToString()
        {
            return $"{Matricula} | {Marca} | {Modelo} | {NumQuadro}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace TPC5
{
    public class Elemento
    {
        private Auto automovel;
        private Elemento proximo;

        public Elemento() { }

        public Elemento Proximo { get => proximo; set => proximo = value; }
        internal Auto Automovel { get => automovel; set => automovel = value; }
    }
}

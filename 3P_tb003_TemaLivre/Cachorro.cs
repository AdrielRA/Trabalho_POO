using System;
using System.Collections.Generic;
using System.Text;

namespace _3P_tb003_TemaLivre
{
    class Cachorro
    {
        private string raca;
        private double peso;

        public string Raca { get { return raca; } set { raca = value; } }
        public double Peso { get { return peso; } set { peso = value; } }

        public Cachorro() { }//AQUI INICIALIZA A LISTA TAMBÉM ?

    }
}

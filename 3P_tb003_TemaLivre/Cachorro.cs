using System;
using System.Collections.Generic;
using System.Text;

namespace _3P_tb003_TemaLivre
{
    class Cachorro:Animal
    {
        private TCor cor_Pelo;

        public string Cor_Pelo { set { cor_Pelo.Nome_cor = value; } }
        public string Comportamento { set { comportamento = value; } }
        public int Expectativa { set { expectativa_vida = value; } }

        public Cachorro(double peso,double altura):base(peso,altura)
        {
            cor_Pelo = new TCor();
            especie = "Cachorro";
        }

        override public string Falar()
        {
            string aux = "Auauau";
            return aux;
        }
       override public string Mostra_Caracteristicas()
        {
            return base.Mostra_Caracteristicas()+ "\n" + 
                   "Caracteristicas do cão:\n" +
                   "Cor do Pelo: " + cor_Pelo.Nome_cor + "\n" +
                   "Fala: " + Falar();
        }
    }
}

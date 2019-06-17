using System;
using System.Collections.Generic;
using System.Text;

namespace _3P_tb003_TemaLivre
{
    class Cachorro:Animal
    {
        private TCor cor_Pelo;
        private string comportamento_cachorro;
        private int expectativa;

        public string Cor_Pelo { set { cor_Pelo.Nome_cor = value; } }
        public string Comportamento { set { comportamento_cachorro = value; } }
        public int Expectativa { set { expectativa = value; } }

        public Cachorro(double peso,double altura):base(peso,altura)
        {
           
        }

        override public string Falar()
        {
            string aux = "Auauau";
            return aux;
        }
       override public string Mostra_Caracteristicas()
        {
            return base.Mostra_Caracteristicas() +"Cor do Pelo :"+ Cor_Pelo +"Som :" +Falar();
        }
    }
}

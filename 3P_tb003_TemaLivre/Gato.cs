using System;
using System.Collections.Generic;
using System.Text;

namespace _3P_tb003_TemaLivre
{
    class Gato : Animal
    {

        private TCor cor_Olhos;
        private string unhas;

        public string Cor_Olhos { set => cor_Olhos.Nome_cor = value; }

        public string Comportamento { set { comportamento = value; } }

        public int Expectativa { set { expectativa_vida = value; } }

        public string Unhas { set => unhas = value; }

        public Gato(double peso, double altura) : base(peso, altura)
        {
            cor_Olhos = new TCor();
            especie = "Gato";
        }

        override public string Falar()
        {
            string aux = "Miau";
            return aux;
        }
        override public string Mostra_Caracteristicas()
        {
            return base.Mostra_Caracteristicas() + "\n" +
                   "Caracteristicas do gato:\n" +
                   "Cor dos olhos: " + cor_Olhos.Nome_cor + "\n" +
                   "Unhas: " + unhas + "\n" +
                   "Fala: " + Falar();
        }
    }
}

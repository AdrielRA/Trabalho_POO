using System;
using System.Collections.Generic;
using System.Text;

namespace _3P_tb003_TemaLivre
{
    class Animal
    {
        public string nome;
        private double peso, altura;
        protected int expectativa_vida;
        protected string especie, comportamento;

        public Animal(double peso, double altura) { this.peso = peso; this.altura = altura; }

        virtual public string Falar() { return ""; }

        virtual public string Mostra_Caracteristicas()
        {
            return "Caracteristicas do Animal:\n" +
                   "Espécie: " + especie + ";\n" +
                   "Nome: " + nome + ";\n" +
                   "Peso: " + peso + " quilo(s);\n" +
                   "Altura: " + altura + " metro(s);\n" +
                   "Comportamento: " + comportamento + ";\n" +
                   "Expectativa de vida: " + expectativa_vida + " ano(s);";
        }
    }
}

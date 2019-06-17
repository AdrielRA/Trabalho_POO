using System;
using System.Collections.Generic;
using System.Text;

namespace _3P_tb003_TemaLivre
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> List_Animais = new List<Animal>();
            //Gato gato = null;
            Cachorro cachorro = null;
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("____________________________________");
                Console.WriteLine(">>> MENU: Animais");
                Console.WriteLine("____________________________________");
                Console.WriteLine("[ 1 ] Cadastrar cães");
                Console.WriteLine("[ 2 ] Cadastrar gatos");
                Console.WriteLine("[ 3 ] Consultar caracteristicas");
                Console.WriteLine("[ 4 ] Sair");
                Console.WriteLine("____________________________________");
                Console.Write("Sua opção: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("____________________________________");
                        Console.WriteLine(">>> CADASTRO: Cães");
                        Console.WriteLine("____________________________________");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        double peso, altura;
                        Console.Write("Peso: ");
                        peso = double.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        altura = double.Parse(Console.ReadLine());
                        cachorro = new Cachorro(peso, altura);
                        cachorro.nome = nome;
                        Console.Write("Expectativa de vida: ");
                        cachorro.Expectativa = int.Parse(Console.ReadLine());
                        Console.Write("Comportamento: ");
                        cachorro.Comportamento = Console.ReadLine();
                        Console.Write("Cor do pelo: ");
                        cachorro.Cor_Pelo = Console.ReadLine();
                        List_Animais.Add(cachorro);
                        break;
                    case 2:
                        //Console.WriteLine("____________________________________");
                        //Console.WriteLine(">>> CADASTRO: Gatos");
                        //Console.WriteLine("____________________________________");
                        //Console.Write("Nome: ");
                        //string nome = Console.ReadLine();
                        //double peso, altura;
                        //Console.Write("Peso: ");
                        //peso = double.Parse(Console.ReadLine());
                        //Console.Write("Altura: ");
                        //altura = double.Parse(Console.ReadLine());
                        //gato = new Gato(peso, altura);
                        //gato.nome = nome;
                        //Console.Write("Expectativa de vida: ");
                        //gato.Expectativa = int.Parse(Console.ReadLine());
                        //Console.Write("Comportamento: ");
                        //gato.Comportamento = Console.ReadLine();
                        //Console.Write("Cor dos olhos: ");
                        //gato.Cor_Olhos = Console.ReadLine();
                        //Console.Write("Tipo de unha: ");
                        //gato.Unhas = Console.ReadLine();
                        //List_Animais.Add(gato);
                        break;
                    case 3:
                        Console.WriteLine("____________________________________");
                        Console.WriteLine(">>> CONSULTA");
                        Console.WriteLine("____________________________________");
                        Consultar(List_Animais);
                        Console.Write(">>> VOLTAR...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

            } while (op != 4);
        }

        static void Consultar(List<Animal> lista)
        {
            foreach (Animal a in lista)
            {
                Console.WriteLine(a.Mostra_Caracteristicas());
                Console.WriteLine("____________________________________");
            }
        }
    }
}

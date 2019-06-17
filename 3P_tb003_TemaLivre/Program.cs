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
            Gato gato = null;
            Cachorro cachorro = null;
            double peso, altura;
            string nome;
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("____________________________________");
                Console.WriteLine(">>> MENU: Animais");
                Console.WriteLine("____________________________________");
                Console.WriteLine("[ 1 ] Cadastrar cães");
                Console.WriteLine("[ 2 ] Cadastrar gatos");
                Console.WriteLine("[ 3 ] Consultar por nome");
                Console.WriteLine("[ 4 ] Consultar todos");
                Console.WriteLine("[ 5 ] Sair");
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
                        nome = Console.ReadLine();
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
                        Console.WriteLine("____________________________________");
                        Console.WriteLine(">>> CADASTRO: Gatos");
                        Console.WriteLine("____________________________________");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Peso: ");
                        peso = double.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        altura = double.Parse(Console.ReadLine());
                        gato = new Gato(peso, altura);
                        gato.nome = nome;
                        Console.Write("Expectativa de vida: ");
                        gato.Expectativa = int.Parse(Console.ReadLine());
                        Console.Write("Comportamento: ");
                        gato.Comportamento = Console.ReadLine();
                        Console.Write("Cor dos olhos: ");
                        gato.Cor_Olhos = Console.ReadLine();
                        Console.Write("Tipo de unha: ");
                        gato.Unhas = Console.ReadLine();
                        List_Animais.Add(gato);
                        break;
                    case 3:
                        Console.WriteLine("____________________________________");
                        Console.WriteLine(">>> CONSULTA: Nome");
                        Console.WriteLine("____________________________________");
                        Console.Write("Nome do animal: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("____________________________________");
                        bool achou = false;
                        foreach (Animal a in List_Animais)
                        {
                            if (a.nome == nome)
                            {
                                Console.WriteLine(a.Mostra_Caracteristicas());
                                Console.WriteLine("____________________________________");
                                achou = true;
                                break;
                            }
                        }
                        if (!achou)
                        {
                            Console.WriteLine("Animal não encontrado!");
                            Console.WriteLine("____________________________________");
                        }
                        Console.Write(">>> VOLTAR...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("____________________________________");
                        Console.WriteLine(">>> CONSULTA: Todos");
                        Console.WriteLine("____________________________________");
                        foreach (Animal a in List_Animais)
                        {
                            Console.WriteLine(a.Mostra_Caracteristicas());
                            Console.WriteLine("____________________________________");
                        }
                        Console.Write(">>> VOLTAR...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (op != 5);
        }
    }
}

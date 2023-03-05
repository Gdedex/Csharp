using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    internal class Program
    {
       public static string NomeJogador;
        static string NomeNamorada;
        static int Amor;
        static int Felicidade;
        static int Raiva;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("##########################");
            Console.WriteLine(" RELASHIONSHIP SIMULATOR");
            Console.WriteLine("##########################");

            Console.WriteLine("Seja bem vindo ao nosso jogo!!!");
            Console.WriteLine("Digite seu nome:");
            NomeJogador = Console.ReadLine();
            Console.WriteLine("olá " + NomeJogador + "!! Digite o nome da sua namorada(o):");
            NomeNamorada = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Seu nome é " + NomeJogador + " e o nome da sua namorada(o) é " + NomeNamorada + " correto?");
            Console.WriteLine("(y/n)");
            string Escolha = (Console.ReadLine());

            if (Escolha == "y")
            {
                Menu();
            }
            else
            {
                Main(args);
            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo");
            Console.WriteLine("1- Elogia");
            Console.WriteLine("2- Irritar");
            Console.WriteLine("3- abraçar e beijar");
            Console.WriteLine("4- Mostrar Pontos");
            Console.WriteLine("5- SAIR ");
            string Opcao = Console.ReadLine();

            switch (Opcao)
            {
                case "1":
                    Elogiar();
                    break;
                case "2":
                    Irritar();
                    break;
                case "3":
                    Beijar();
                    break;
                case "4":
                    Mostrar();
                    break;
                case "5":
                    Console.ReadKey(); 
                    break;
            }
        }
        static void Elogiar ()
        {
            Amor++;
            Felicidade++;
            Console.WriteLine(NomeJogador + " decidiu elogiar " + NomeNamorada);
            Console.WriteLine(NomeJogador + " recebe:");
            Console.WriteLine("Amor +1");
            Console.WriteLine("Felicidade +1");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla");
            Console.ReadKey();
            Menu();
        }
        static void Irritar()
        {
            Raiva++;
            Amor--;
            Felicidade--;
            Console.WriteLine(NomeJogador + " decidiu irritar " + NomeNamorada);
            Console.WriteLine(NomeJogador + " recebe:");
            Console.WriteLine("Raiva +1");
            Console.WriteLine("Felicidade -1");
            Console.WriteLine("Amor -1");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla");
            Console.ReadKey();
            Menu();
        }
        static void Beijar()
        {
            Amor+=2;
            Felicidade+=2;
            Raiva--;
            Console.WriteLine(NomeJogador + " decidiu beijar " + NomeNamorada);
            Console.WriteLine(NomeJogador + " recebe:");
            Console.WriteLine("Amor +2");
            Console.WriteLine("Felicidade +2");
            Console.WriteLine("Raiva -1");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla");
            Console.ReadKey();
            Menu();
        }
        static void Mostrar()
        {
            Console.WriteLine("STATUS DE " + NomeJogador + ":");
            Console.WriteLine("AMOR = " + Amor);
            Console.WriteLine("FELICIDADE = " + Felicidade);
            Console.WriteLine("RAIVA = " + Raiva);
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla");
            Console.ReadKey();
            Menu();
        }
    }
}
        
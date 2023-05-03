using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessão_de_Testes
{
    internal class Program
    {
        struct dadosAluno
        {
            public string nome;
            public string curso;
            public DateTime nascimento;
            public string sala;
        }
        static void Main(string[] args)
        {
            List<dadosAluno> alunosCadastrados = new List<dadosAluno>();
            dadosAluno Aluno;
            string opcao;

            do
            {
                Console.WriteLine("Digite C para CADASTRAR / Digite S para SAIR");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                Console.Clear();
                
                if (opcao == "c")
                {
                    Console.WriteLine("__________________________________");
                    Console.WriteLine("         CADASTRO DO ALUNO");
                    Console.WriteLine("__________________________________");
                    Console.WriteLine();

                    Console.Write("NOME: ");
                    Aluno.nome = Console.ReadLine();
                    Console.Write("DATA DE NASCIMENTO: ");
                    Aluno.nascimento = DateTime.Parse(Console.ReadLine());
                    Console.Write("CURSO: ");
                    Aluno.curso = Console.ReadLine();
                    Console.Write("SALA: ");
                    Aluno.sala = Console.ReadLine();
                    alunosCadastrados.Add(Aluno);
                    Console.Clear();
                    Console.WriteLine("Aluno Cadastrado...");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    Console.WriteLine("Finalizando programa...");
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }
            }
            while (opcao != "s");
        }
    }
}

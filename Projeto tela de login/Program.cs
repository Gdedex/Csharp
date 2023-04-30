using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_tela_de_login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("DIGITE O USUÁRIO: ");
                string usuario = Console.ReadLine();
                Console.WriteLine("DIGITE SUA SENHA: ");
                string senha = "";
                while (true)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true); //NÃO MOSTRA A SENHA DIGITADA PELA USUÁRIO
                    if (tecla.Key == ConsoleKey.Enter) //TERMINA O LOOP CASO O ENTER SEJA PRESSIONADO
                    {
                        break;
                    }
                    else
                    {
                        senha += tecla.KeyChar; //JUNTA A TECLA DIGITADA A SENHA
                    }
                }
                if (usuario == "gabriel" && senha == "1234") //LOGIN DE ACESSO USER = GABRIEL / SENHA = 1234
                {
                    Console.WriteLine("Login realizado com sucesso!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Usuário ou senha incorretos");
                    Console.WriteLine("Tente novamente");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}

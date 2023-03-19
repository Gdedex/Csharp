using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, salarioFinal;
            string nome, sobrenome;
            int idade;
            int filhos;
            string cargo;
            double valorhora, horas, horasExtras;
            string data;
            string cpf;
            double atrasos;
            string decisao;

            Console.WriteLine("Bem vindo ao gerador de folha de pagamento");
            Console.WriteLine();
            Console.WriteLine("Vamso começar!!");
            Console.WriteLine();
            Console.WriteLine("Digite o primerio nome do empregado: ");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite o sobrenome do empregado: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite CPF: ");
            cpf= Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Os dados estão corretos? ");
            Console.WriteLine("Nome: {0} ", nome + " " + sobrenome);
            Console.WriteLine();
            Console.WriteLine("Idade: {0}", idade);
            Console.WriteLine();
            Console.WriteLine("CPF: {0}\n", cpf);
            Console.WriteLine("S OU N ");
            decisao= Console.ReadLine();
            
            if (decisao == "N" || decisao == "n")
            {
                Console.Clear();
                Console.WriteLine("Insira os dados do funcionário novamente");
                Main(args);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Insira as características profissionais de {0}\n", nome);
                Console.WriteLine("Qual a profissão de {0}?", nome);
                cargo= Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("{0} possui um contrato ou ganha por horas trabalhadas? \n", nome);
                Console.WriteLine("(C: Contrato / H: Horas trabalhadas)");
                decisao = Console.ReadLine();
                if (decisao == "C" || decisao == "c")
                {
                    Console.Clear();
                    Console.WriteLine("Qual o salário contratual de {0}?", nome);
                    salario = double.Parse(Console.ReadLine());
                    salarioFinal = salario;
                    Console.WriteLine();
                    Console.WriteLine("Qual o valor da hora de {0}?", nome);
                    valorhora = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("{0} fez horas extras? ", nome);
                    Console.WriteLine("S/N");
                    Console.WriteLine();
                    decisao= Console.ReadLine();

                    if (decisao == "S" || decisao == "s")
                    {
                        Console.Clear();
                        Console.WriteLine("Quantas horas extras {0} fez?", nome);
                        horas = double.Parse(Console.ReadLine());
                        horasExtras = horas * (valorhora + valorhora*0.4);
                        salarioFinal += horasExtras;
                    }
                    else
                    {
                        horas = 0;
                        horasExtras= 0;
                    }

                        Console.Clear();
                        Console.WriteLine("Sabendo que nossa empresa possui um auxilio para funcionários que possuem filhos");
                        Console.WriteLine("quantos filhos tem {0}?", nome);
                        Console.WriteLine("0 - NENHUM FILHO");
                        Console.WriteLine("1 - UM FILHO");
                        Console.WriteLine("2 - DOIS FILHOS");
                        Console.WriteLine("3 - 3 OU MAIS FILHOS");
                        filhos = int.Parse(Console.ReadLine());

                        switch (filhos)
                        {
                            case 0:
                                Console.WriteLine("Não será disponibilizado beneficio ao funcionário");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualque tecla para continuar");
                            Console.ReadKey();
                                break;
                            case 1:
                                salarioFinal += 200.00;
                                Console.WriteLine("Para funcionários com um filho nossa empresa concede R$200,00 a mais");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualque tecla para continuar");
                            Console.ReadKey();
                            break;
                            case 2:
                                salarioFinal += 400.00;
                                Console.WriteLine("Para funcionários com dois filhos nossa empresa concede R$400,00 a mais");
                                Console.WriteLine("R$200,00 para cada filho");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualque tecla para continuar");
                            Console.ReadKey();
                            break;
                            case 3:
                                salarioFinal += 600.00;
                                Console.WriteLine("Para funcionários com três ou mais filhos nossa empresa concede R$600,00 a mais");
                                Console.WriteLine("R$200,00 para cada filho");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualque tecla para continuar");
                            Console.ReadKey();
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("{0} teve atrasos no decorrer do mês? ", nome);
                        Console.WriteLine("S/N");
                        decisao = Console.ReadLine();

                        if (decisao == "s" || decisao == "S")
                        {
                            Console.WriteLine("Quantas horas {0} se atrasou?: ", nome);
                            horas = double.Parse(Console.ReadLine());
                            atrasos = horas * (valorhora * 0.8);
                            salarioFinal -= atrasos;
                        }
                        else
                    {
                        atrasos = 0;
                    }
                    Console.Clear();
                    Console.WriteLine("Pressione qualquer tecla para gerar a folha de pagamento de {0}", nome);
                    Console.ReadKey();

                    Console.Clear();

                    Console.WriteLine("O {0} {1} portador do CPF: {2}, irá receber o valor líquido de: R${3} este mês", cargo, nome + " " + sobrenome, cpf, salarioFinal);
                    Console.WriteLine("Sendo esse valor derivado de: ");
                    Console.WriteLine("Valor do contrato = R${0}", salario);
                    Console.WriteLine("Valor de  horas extras = R${0}", horasExtras);
                    Console.WriteLine("Desconto referente a atrasos = R${0}",  atrasos);
                    Console.WriteLine("Auxilio para pais = R${0}", filhos * 200);
                    Console.ReadKey();
                }

                else if (decisao == "H" || decisao == "h")
                {
                    Console.Clear();
                    Console.WriteLine("Quantas horas {0} trabalhou?", nome);
                    horas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor da hora de {0}?", nome);
                    valorhora = double.Parse(Console.ReadLine());
                    salario = horas * valorhora;
                    salarioFinal = horas * valorhora;
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Sabendo que nossa empresa possui um auxilio para funcionários que possuem filhos");
                    Console.WriteLine("quantos filhos tem {0}?", nome);
                    Console.WriteLine("0 - NENHUM FILHO");
                    Console.WriteLine("1 - UM FILHO");
                    Console.WriteLine("2 - DOIS FILHOS");
                    Console.WriteLine("3 - 3 OU MAIS FILHOS");
                    filhos = int.Parse(Console.ReadLine());

                    switch (filhos)
                    {
                        case 0:
                            Console.WriteLine("Não será disponibilizado beneficio ao funcionário");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualque tecla para continuar");
                            Console.ReadKey();
                            break;
                        case 1:
                            salarioFinal += 200.00;
                            Console.WriteLine("Para funcionários com um filho nossa empresa concede R$200,00 a mais");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualque tecla para continuar");
                            Console.ReadKey();
                            break;
                        case 2:
                            salarioFinal += 400.00;
                            Console.WriteLine("Para funcionários com dois filhos nossa empresa concede R$400,00 a mais");
                            Console.WriteLine("R$200,00 para cada filho");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualque tecla para continuar");
                            Console.ReadKey();
                            break;
                        case 3:
                            salarioFinal += 600.00;
                            Console.WriteLine("Para funcionários com três ou mais filhos nossa empresa concede R$600,00 a mais");
                            Console.WriteLine("R$200,00 para cada filho");
                            Console.WriteLine();
                            Console.WriteLine("Pressione qualque tecla para continuar");
                            Console.ReadKey();
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine("{0} teve atrasos no decorrer do mês? ", nome);
                    Console.WriteLine("S/N");
                    decisao = Console.ReadLine();

                    if (decisao == "s" || decisao == "S")
                    {
                        Console.WriteLine("Quantas horas {0} se atrasou?: ", nome);
                        horas = double.Parse(Console.ReadLine());
                        atrasos = horas * (valorhora * 0.8);
                        salarioFinal -= atrasos;
                    }
                    else
                    {
                        atrasos = 0;
                    }
                    Console.Clear();
                    Console.WriteLine("Pressione qualquer tecla para gerar a folha de pagamento de {0}", nome);
                    Console.ReadKey();

                    Console.Clear();

                    Console.WriteLine("O {0} {1} portador do CPF: {2}, irá receber o valor líquido de: R${3} este mês", cargo, nome + " " + sobrenome, cpf, salarioFinal);
                    Console.WriteLine("Sendo esse valor derivado de: ");
                    Console.WriteLine("Valor de  horas trabalhadas = R${0}", salario);
                    Console.WriteLine("Desconto referente a atrasos = R${0}", atrasos);
                    Console.WriteLine("Auxilio para pais = R${0}", filhos * 200);
                    Console.ReadKey();
                }

            }
        }
    }
}

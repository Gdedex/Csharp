using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            int Escolha;
            Console.WriteLine("Calculadora Simples");
            Console.WriteLine();
            Console.WriteLine("1- ADIÇÃO");
            Console.WriteLine("2- SUBTRAÇÃO");
            Console.WriteLine("3- MULTIPLICAÇÃO");
            Console.WriteLine("4- DIVISÃO");
            Console.WriteLine("5- POTENCIAÇÃO");
            Console.WriteLine("6- RAIZ QUADRADA");
            Console.WriteLine("7- BHASKARA");
            Console.WriteLine("8- SAIR");
            Escolha = Convert.ToInt32(Console.ReadLine());

            switch (Escolha)
            {
                case 1:
                    Adicao();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    Potenciacao();
                    break;
                case 6:
                    Raiz();
                    break;
                case 7:
                    Bascara();
                    break;
                case 8:
                    Console.WriteLine("Pressione qualquer tecla para sair");
                    Console.ReadKey();
                    break;
            }
        }
        static void Adicao()
        {
            double numero1, numero2;
            double resultado;
            Console.Write("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 + numero2;
            Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado);
            Console.ReadLine();
            Menu();
        }
        static void Subtracao()
        {
            double numero1, numero2;
            double resultado;
            Console.Write("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 - numero2;
            Console.WriteLine(numero1 + " - " + numero2 + " = " + resultado);
            Console.ReadLine();
            Menu();
        }
        static void Multiplicacao()
        {
            double numero1, numero2;
            double resultado;
            Console.Write("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 * numero2;
            Console.WriteLine(numero1 + " X " + numero2 + " = " + resultado);
            Console.ReadLine();
            Menu();
        }
        static void Divisao()
        {
            double numero1, numero2;
            double resultado;
            Console.Write("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 / numero2;
            Console.WriteLine(numero1 + " / " + numero2 + " = " + resultado);
            Console.ReadLine();
            Menu();
        }
        static void Potenciacao()
        {
            double numero1, numero2;
            double resultado;
            Console.Write("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = Math.Pow (numero1, numero2);
            Console.WriteLine(numero1 + " elevado a " + numero2 + " = " + resultado);
            Console.ReadLine();
            Menu();
        }
        static void Raiz()
        {
            double numero1, numero2;
            double resultado;
            Console.Write("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());
            resultado = Math.Sqrt (numero1);
            Console.WriteLine("A raiz quadrada de " + numero1 + " é " + resultado);
            Console.ReadLine();
            Menu();
        }
        static void Bascara()
        {
            double a, b, c, x1, x2, Delta;
            Console.Write("A= ");
            a = double.Parse(Console.ReadLine());
            Console.Write("B= ");
            b = double.Parse(Console.ReadLine());
            Console.Write("C= ");
            c = double.Parse(Console.ReadLine());

            Delta = Math.Pow(b, 2) - 4 * a * c;

            if (Delta < 0)
            {
                Console.WriteLine("Delta não possui uma raiz real");
                Console.ReadKey();
            }
            else if (Delta == 0)
            {
                x1 = -b / 2 * a;
                Console.WriteLine("A equação só possui uma raiz real: {0}", x1);
                Console.ReadKey();
            }
            else
            {
                x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(Delta)) / (2 * a);
                Console.WriteLine("As raízes são: x1 = {0} e x2 = {1}", x1, x2);
                Console.ReadKey();
            }

            Menu();
        }
    }
}
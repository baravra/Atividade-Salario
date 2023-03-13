using System;
using System.Runtime.ConstrainedExecution;
using System.Globalization;
using Atividade_3___Salario;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês(em dinheiro).
             * Sabendo que este vendedor ganha 15 % de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais. 
             * Faça uso de ao menos uma classe, onde os atributos podem ser públicos.*/

            string nome;
            double salarioFixo, vendas;

            Console.WriteLine("Insira seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Insira seu salario fixo:");
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o total de vendas:");
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Dindin dindin = new Dindin();
            dindin.vendedor = nome;
            dindin.vendas = vendas;
            dindin.salario = salarioFixo;

            dindin.CalculoSalario();


        }
    }
}
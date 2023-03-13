using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3___Salario
{
    public class Dindin 
    {
        public string vendedor;
        public double salario, vendas;

        public void CalculoSalario()
        {
            double totalRecebimento = (vendas * 0.15) + salario;

            Console.WriteLine();
            Console.WriteLine($"{vendedor} recebeu de salário mais comissão = R${totalRecebimento.ToString("f2")}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal abstract class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;

            Console.WriteLine("Criando FUNCIONARIO");
        }
        //Metodos abstratos
        public abstract void AumentarSalario();
       
        public abstract double GetBonificacao();//Permitir alteração do metedo de uma classe herdada
        

    }
}

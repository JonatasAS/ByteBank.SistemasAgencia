using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(4000, cpf)
        {

            Console.WriteLine("Criando Desenvolvedor");

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        internal protected override double GetBonificacao()
        {
           return Salario = 0.1;
        }       
    }
}

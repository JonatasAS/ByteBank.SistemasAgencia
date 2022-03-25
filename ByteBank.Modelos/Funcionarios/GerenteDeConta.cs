using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class GerenteDeConta : FuncionarioAutenticavel
    {
       
        public GerenteDeConta(double salario, string cpf) : base(salario, cpf)
        {
            Console.WriteLine("Criando Gerente de Contas");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}

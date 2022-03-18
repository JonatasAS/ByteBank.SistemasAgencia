using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Diretor : FuncionarioAutenticavel
    {
        public Diretor(double salario, string cpf) : base(salario, cpf)
        {
            Console.WriteLine("Criando Diretor");
           
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao() //Ira sobrepor o metodo
        {
            return Salario * 0.5;
        }

    }
}

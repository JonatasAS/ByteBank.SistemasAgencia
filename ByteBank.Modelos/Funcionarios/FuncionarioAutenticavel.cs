using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AutenticarHelper _autenticacaoHelper = new AutenticarHelper();
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }
        public bool Autenticar (string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}

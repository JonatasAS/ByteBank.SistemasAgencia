using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.Modelos
{
    internal class ParceiroComercial : IAutenticavel
    {    
        private AutenticarHelper _autenticacaoHelper = new AutenticarHelper();
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
        public ParceiroComercial()
        {           
            Console.WriteLine("Criando parceiro comercial!");
        }

       
    }
}

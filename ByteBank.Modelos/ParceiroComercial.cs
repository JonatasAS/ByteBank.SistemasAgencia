using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank
{
    internal class ParceiroComercial : IAutenticavel
    {       
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
          
        }
        public ParceiroComercial()
        {           
            Console.WriteLine("Criando parceiro comercial!");
        }

       
    }
}

using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal interface IAutenticavel 
    {
        bool Autenticar(string senha);
    }
}

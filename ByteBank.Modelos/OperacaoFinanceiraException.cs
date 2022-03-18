using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException() // Construtor sem argumento
        {

        }
        public OperacaoFinanceiraException(string mensagem) : base(mensagem) // Construtor com mensagem 
        {

        }
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna) // Construtor com mensagem e InnerException
        {

        }
    }
}

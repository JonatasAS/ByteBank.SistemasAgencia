using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2022, 7, 22);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - DateTime.Now;

            string mensagem = "Vencimento em " + GetIntervaloDeTempoLegivel(diferenca);

            Console.WriteLine(mensagem);

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);

            Console.ReadLine();
        } 
        
        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if (timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                if (quantidadeMeses == 1)
                {
                    return "1 mês";
                }
                return quantidadeMeses + "Meses";                
            }
            else if (timeSpan.Days > 7)
            {
                int quantidadeSemanas = timeSpan.Days / 7;
            }
            return timeSpan.Days + " dias";
        }
    }
}

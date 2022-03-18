
using System;

namespace ByteBank.Modelos
    
{
    public class ContaCorrente
    {
        public static int TaxaOperacao { get; set; }        
        public Cliente Titular { get; set; } 
        public static int TotalDeContasCriadas { get; private set; } 
        public  int Agencia { get; }  //somente leitura           
        public int Numero { get; } // somente leitura
        public int ContadorSaquesNaoPermitidos { get; private set; }  
        public int ContadorTransferenciasNaoPermitidas { get; private set; }    
        public ContaCorrente(int agencia, int numero) 
        {
            // Exceção 
            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }      
            
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;
           
            TotalDeContasCriadas++; // Logica da propriedade static
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
        
        private double _saldo = 100;// default
        public double Saldo  
        {            
            get 
            {
                return _saldo; 
            }
            set  
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value; 
            }
        }
        //função
        public void Sacar(double valor)                                        
        {
            if (valor < 0)
            {
                throw new ArgumentException("valor inválido para saque. ", nameof(valor));
            }
            if (_saldo < valor)  
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);

            }                        
                _saldo -= valor; 
        }
        //metodo
        public void Depositar(double valor) 
        {
            this._saldo += valor; 
        }

        //função
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            
            if (valor < 0)
            {
                throw new ArgumentException("Valor invádo para transferência. ", nameof(valor)); 
            }
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Saldo insuficiênte em conta ",ex);//execeção interna(innerexception) encapsulamento
            }
            contaDestino.Depositar(valor);          
        }
    }
}





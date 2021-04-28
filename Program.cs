using System;

namespace TrilhaEspec_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conta Corrente
            ContaCorrente contaCorrentePessoa1 = new ContaCorrente{
                Agencia = 1,
                Numero = 101,
                Titular = "Antonio",
                Saldo = 3400.0
            };
            
            Console.WriteLine("Os dados da conta corrente são:");
            Console.WriteLine("Agência: " + contaCorrentePessoa1.Agencia.ToString());
            Console.WriteLine("Número: " + contaCorrentePessoa1.Numero.ToString());
            Console.WriteLine("Titular: " + contaCorrentePessoa1.Titular.ToString());
            Console.WriteLine("Saldo: R$" + contaCorrentePessoa1.Saldo.ToString());
            contaCorrentePessoa1.Saldo = contaCorrentePessoa1.Sacar(500.0, contaCorrentePessoa1.Saldo);
            Console.WriteLine("Após sacar R$500,00 o saldo ficou: R$" + contaCorrentePessoa1.Saldo.ToString());
            contaCorrentePessoa1.Saldo = contaCorrentePessoa1.Depositar(150.0, contaCorrentePessoa1.Saldo);
            Console.WriteLine("Após depositar R$150,00 o saldo ficou: R$" + contaCorrentePessoa1.Saldo.ToString());
            
            //===========================================================================
            //Conta Poupança
            ContaCorrente contaPoupancaPessoa1 = new ContaPoupanca{
                Agencia = 1,
                Numero = 102,
                Titular = "Maria",
                Saldo = 5500.0
            };
            
            Console.WriteLine("===================================================");
            Console.WriteLine("Os dados da conta poupança são:");
            Console.WriteLine("Agência: " + contaPoupancaPessoa1.Agencia.ToString());
            Console.WriteLine("Número: " + contaPoupancaPessoa1.Numero.ToString());
            Console.WriteLine("Titular: " + contaPoupancaPessoa1.Titular.ToString());
            Console.WriteLine("Saldo: R$" + contaPoupancaPessoa1.Saldo.ToString());
            contaPoupancaPessoa1.Saldo = contaPoupancaPessoa1.Sacar(500.0, contaPoupancaPessoa1.Saldo);
            Console.WriteLine("Após sacar R$500,00 o saldo ficou: R$" + contaPoupancaPessoa1.Saldo.ToString());
            contaPoupancaPessoa1.Saldo = contaPoupancaPessoa1.Depositar(150.0, contaPoupancaPessoa1.Saldo);
            Console.WriteLine("Após depositar R$150,00 o saldo ficou: R$" + contaPoupancaPessoa1.Saldo.ToString());
            Console.WriteLine("Caso não realize nenhum saque/depósito, o saldo daqui um mês será de: R$" + contaPoupancaPessoa1.PrevisaoRendimentoMensal(contaPoupancaPessoa1.Saldo));
        }
    }

    public class ContaCorrente
    {
        public int Agencia {get; set;}
        public int Numero {get; set;}
        public string Titular {get; set;}
        public double Saldo {get; set;}

        public double Sacar(double valorSaque, double saldoConta)
        {
            if (saldoConta >= valorSaque)
            {
                saldoConta -= valorSaque;
            }
            return saldoConta;
        }
        public double Depositar(double valorDeposito, double saldoConta)
        {
            if (valorDeposito > 0)
            {
                saldoConta += valorDeposito;
            }
            return saldoConta;
        }
    }

    public class ContaPoupanca : ContaCorrente
    {
        public double PrevisaoRendimentoMensal(double saldoConta)
        {
            return saldoConta += (saldoConta * 0.01);
        }
    }
}

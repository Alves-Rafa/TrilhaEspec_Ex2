namespace TrilhaEspec_Ex2.obj
{
    public class ContaCorrente
    {
        public int Numero {get ; set;}
        public string Titular {get; set;}
        public double Saldo {get ; set;}

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
}
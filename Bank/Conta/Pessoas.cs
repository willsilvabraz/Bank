using System;


namespace Bank
{
    public class Conta
    {
        TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }
        

        public Conta(TipoConta tipoConta,
                     double saldo,
                     double credito,
                     string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public bool Sacar (double ValorSaque)
        {
            if (this.Saldo - ValorSaque < (this.Credito * -1)) 
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            this.Saldo -= ValorSaque;
            Console.WriteLine($"Saldo Atual Da Conta De {this.Nome} é de {this.Saldo} ");
            return true;
        }
        public void Depositar(double ValorDeposito)
        {
            this.Saldo += ValorDeposito;
            Console.WriteLine($"Saldo Atual Da Conta De {this.Nome} é de {this.Saldo} ");
        }
        public void Transferir(double ValorTransferencia, Conta ContaDestino)
        {
            if (this.Sacar(ValorTransferencia))
            {
                ContaDestino.Depositar(ValorTransferencia);
            }
        }
        public override string ToString()
        {
            string Retorno = "";
            Retorno += "TipoConta " + this.TipoConta + " | ";
            Retorno += "Nome " + this.Nome + " | ";
            Retorno += "Saldo " + this.Saldo + " | ";
            Retorno += "Credito " + this.Credito + " | ";

            return Retorno;
        }

    }
}

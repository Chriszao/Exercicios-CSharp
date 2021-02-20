using System.Globalization;

namespace Banco
{
    class ContaBancaria
    {
        //Atributos baseados em properties
        public string Titular { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        //Sobrecarga de construtores]
        public ContaBancaria(string titular, int numero)
        {
            Titular = titular;
            Numero = numero;
        }

        public ContaBancaria(string titular, int numero, double depositoInicial) : this (titular, numero)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = (Saldo - quantia) - 5.00;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

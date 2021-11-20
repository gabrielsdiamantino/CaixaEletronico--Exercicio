using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CaixaEletronico
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; } //privado pois só vai poder ser alterado pela função Depositar ou Sacar.

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;  //os 5.0 adicionados representam a taxa solicitada no exercicio.
        }

        public override string ToString()
        {
            return "Conta"
                + Numero
                + ", titular "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
                ;

        }
    }
}

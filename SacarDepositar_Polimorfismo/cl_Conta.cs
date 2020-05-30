using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacarDepositar_Polimorfismo
{
    class cl_Conta
    {
        // Herança, virtual, override
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public virtual void creditar(double valor)
        {
            Saldo += valor;
        }

        public virtual void debitar(double valor)
        {
            Saldo -= valor;
        }

    }
}

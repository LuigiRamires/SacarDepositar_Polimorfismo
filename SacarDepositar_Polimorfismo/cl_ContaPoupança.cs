using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacarDepositar_Polimorfismo
{
    class cl_ContaPoupança: cl_Conta
    {
        public override void creditar(double valor)
        {
            Saldo += (0.05 * valor) + valor;
        }

        public override void debitar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
        }
    }
}

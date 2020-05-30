using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacarDepositar_Polimorfismo
{
    class cl_ContaEspecial: cl_Conta
    {
        public override void debitar(double valor)
        {
            if(Saldo <= 0)
            {
                Saldo -= (valor * 0.01) + valor;
            }
            else
            {
                Saldo -= valor;
            }
        }
    }
}

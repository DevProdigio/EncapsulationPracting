using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    class ContaBancaria
    {
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor && valor > 0)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque no valor de {valor}$ efetuado com sucesso. Novo saldo {Saldo}$");
            }
            else if (Saldo < valor){
                Console.WriteLine($"Você não tem saldo suficiente. Saldo atual {Saldo}$");

            }
            else
            {
                Console.WriteLine("Valor invalido!");
            }
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Deposito no valor de {valor}$ efetuado com suscesso. Novo saldo {Saldo}$");
            }
            else
            {
                Console.WriteLine("Valor do deposito invalido ou insuficiente.");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo Atual: {Saldo}$");
        }
    }
}

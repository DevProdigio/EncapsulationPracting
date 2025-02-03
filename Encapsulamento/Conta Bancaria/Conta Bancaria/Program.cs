using System;
using Conta_Bancaria;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Depositar(5000);
        conta.Sacar(1000);
        conta.ConsultarSaldo();
    }
}
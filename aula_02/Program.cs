
using System;

namespace aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta objContaDoJoao = new Conta(1234,"João da Silva");

            w($"Num. Conta: {objContaDoJoao.numero}.");

            objContaDoJoao.Depositar(1000);
            w($"Saldo do: {objContaDoJoao.titular} é {objContaDoJoao.saldo}.");
             objContaDoJoao.Sacar(500);
            w($"Saldo do: {objContaDoJoao.titular} é {objContaDoJoao.saldo}.");
            r();

        }

        static void w(string msg)
        {
            Console.WriteLine(msg);
        }

        static void r()
        {
            Console.ReadLine();
        }
    }
}

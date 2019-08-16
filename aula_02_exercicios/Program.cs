using System;
using aula_02_exercicios.incs;

namespace aula_02_exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes oAllan = new Clientes("Allan", 1234);
            Clientes oAmanda = new Clientes("Amanda", 5678);

            w("");
            w($"Código: {oAllan.codigo} - Nome: {oAllan.nome}");
            w($"Código: {oAmanda.codigo} - Nome: {oAmanda.nome}");

            Card oAllanCard = new Card(1111222233334444, new DateTime(2019,12,31), 1234);
            Card oAmandaCard = new Card(5555666677778888, new DateTime(2020,10,31), 1234);

            w("");
            w($"Cartão: {oAllanCard.cartao} - Validade: {oAllanCard.validade.ToString("MM-yyyy")}");
            w($"Cartão: {oAmandaCard.cartao} - Validade: {oAmandaCard.validade.ToString("MM-yyyy")}");

            Agencias oAgencia1 = new Agencias("1234-0");
            Agencias oAgencia2 = new Agencias("5678-1"); 

            w("");
            w($"Agência: {oAgencia1.numero}");
            w($"Agência: {oAgencia2.numero}");

            Contas oConta1 = new Contas(4321, 1000, 100);
            Contas oConta2 = new Contas(8765, 2000, 100);

            w("");
            w($"Conta: {oConta1.numero} - Saldo {oConta1.saldo} - Limite {oConta1.limite}");
            w($"Conta: {oConta2.numero} - Saldo {oConta2.saldo} - Limite {oConta2.limite}");
            w("");

            oConta1.Depositar(1000);
            w($"Saldo após Depósito de 1000: {oConta1.numero} é {oConta1.saldo}.");
            w("");

            oConta1.Sacar(333);
            w($"Saldo após Saque de 333: {oConta1.numero} é {oConta1.saldo}.");
            w("");

            oConta1.Transferencia(oConta1, 100, oConta2, 100);
            w($"Saldo Conta 4321 após Transferência de 100: {oConta1.numero} é {oConta1.saldo}.");
            w($"Saldo Conta 8765 após Transferência de 100: {oConta2.numero} é {oConta2.saldo}.");

            Gerentes oGerente1 = new Gerentes("Allan Silveira", 5000);
            oGerente1.aumentaSalario();

            w("");
            w($"Gerente: {oGerente1.nome} - Salário com 10% de aumento {oGerente1.salario}");

            Gerentes oGerente2 = new Gerentes("Allan Silveira", oGerente1.salario);
            oGerente2.aumentaSalario(7);

            w("");
            w($"Gerente: {oGerente2.nome} - Salário anterior com novo aumento 7% de aumento {oGerente2.salario}");
            w("");
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

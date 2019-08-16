using System;

namespace aula_02_exercicios.incs
{
    public class Contas
    {
        public Contas(int numero, double saldo, double limite)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.limite = 100;
        }
        public int numero { get; private set; }
        public double saldo { get; private set; }
        public double limite { get; private set; }
        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public void Sacar(double valor)
        {
            saldo -= valor;
        }
        public void Transferencia(Contas contaOrigem, double saldoOrigem, Contas contaDestino, double saldoDestino)
        {
            if(this.saldo > 0 && this.saldo >= saldoOrigem)
            {
                contaOrigem.Sacar(saldoOrigem);
                contaDestino.Depositar(saldoDestino);
            }
            else
            {
                throw new Exception("Limite indisponível.");
            }
        }

    }
}
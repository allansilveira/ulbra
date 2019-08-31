using System;

namespace aula_03_exercicios
{
    public class Reservas
    {
        public Reservas(DateTime dataReserva, DateTime dataValidade)
        {
            this.dataReserva = dataReserva;
            this.dataValidade = dataValidade;
        }

        public DateTime dataReserva { get; private set; }
        public DateTime dataValidade { get; private set; }

        public void Reservar(Materiais codigoR, Reservas inicioR)
        {
            w($"#{codigoR.codigo} - Início: {inicioR.dataReserva.ToString("dd/MM/yyyy")} - Fim: {inicioR.dataValidade.ToString("dd/MM/yyyy")}");
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
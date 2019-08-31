using System;

namespace aula_03_exercicios
{
    public class Usuarios
    {
        public Usuarios(string nome, string local, long telefone, string senha)
        {
            this.nome = nome;
            this.local = local;
            this.telefone = telefone;
            this.senha = senha;
        }

        public string nome { get; private set; }
        public string local { get; private set; }
        public long telefone { get; private set; }
        public string senha { get; private set; }

        public class Emprestimo
        {
            public Emprestimo(DateTime dataInicio, DateTime dataFim, int atraso)
            {
                this.dataInicio = dataInicio;
                this.dataFim = dataFim;
            }

            public DateTime dataInicio { get; private set; }
            public DateTime dataFim { get; private set; }

            public void Emprestar(Usuarios nomeE, Materiais codigoE, Emprestimo inicioE)
            {
                w($"Nome: {nomeE.nome} - #{codigoE.codigo} - Início: {inicioE.dataInicio.ToString("dd/MM/yyyy")} - Fim: {inicioE.dataFim.ToString("dd/MM/yyyy")}");
            }
        }
        public class Devolucao
        {
            public Devolucao(DateTime dataEntrega)
            {
                this.dataEntrega = dataEntrega;
            }

            public DateTime dataEntrega { get; private set; }

            public void Devolver(Usuarios nomeD, Materiais codigoD, Devolucao entregaD, Emprestimo fimE)
            {
                if(entregaD.dataEntrega > fimE.dataFim)
                {
                    TimeSpan date = Convert.ToDateTime(entregaD.dataEntrega) - Convert.ToDateTime(fimE.dataFim);
                    int totalDias = date.Days;

                    w($"Nome: {nomeD.nome} - #{codigoD.codigo} - Devolução: {entregaD.dataEntrega.ToString("dd/MM/yyyy")} - Dias de Atraso: {totalDias}");
                }
                else
                {
                    w($"Nome: {nomeD.nome} - #{codigoD.codigo} - Devolução: {entregaD.dataEntrega.ToString("dd/MM/yyyy")}");
                }
            }
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
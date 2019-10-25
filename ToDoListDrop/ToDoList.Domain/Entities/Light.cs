using System;

namespace ToDoList.Domain.Entities
{
    public class Light
    {
        public Light(){ }
        public Light(int id, DateTime dataLeitura, int numeroLeitura, int kw, double valor, DateTime dataPagamento, double media, House house)
        {
            this.id = id;
            this.dataLeitura = dataLeitura;
            this.numeroLeitura = numeroLeitura;
            this.kw = kw;
            this.valor = valor;
            this.dataPagamento = dataPagamento;
            this.media = media;
            this.house = house;
        }
        public int id { get; set; }
        public DateTime dataLeitura { get; set; }
        public int numeroLeitura { get; set; }
        public int kw { get; set; }
        public double valor { get; set; }
        public DateTime dataPagamento { get; set; }
        public double media { get; set; }
        public House house { get; set; }
    }
}
using System;

namespace aula_02_exercicios.incs
{
    public class Card
    {
        public Card(long cartao, DateTime validade, int codigo)
        {
            this.cartao = cartao;
            this.validade = validade;
            this.codigo = codigo;
        }

        public long cartao { get; private set; }
        public DateTime validade { get; private set; }
        public int codigo { get; private set; }
    }
}
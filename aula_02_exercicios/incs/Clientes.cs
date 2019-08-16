namespace aula_02_exercicios.incs
{
    public class Clientes
    {
        public Clientes(string nome, int codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }

        public string nome { get; private set; }
        public int codigo { get; private set; }
    }
}
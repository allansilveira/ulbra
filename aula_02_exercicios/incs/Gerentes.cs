namespace aula_02_exercicios.incs
{
    public class Gerentes
    {
        public Gerentes(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public string nome { get; private set; }
        public double salario { get; private set; }

        public void aumentaSalario()
        {
            this.salario += (salario*0.10);
        }
        public void aumentaSalario(double taxa)
        {
            this.salario += (salario*(taxa/100));
        }
    }
}
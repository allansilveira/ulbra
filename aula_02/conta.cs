namespace aula_02
{
    public class Conta
    {
        public Conta (int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
        }
        
        public int numero { get; private set; }
        
        public string titular { get; private set; }
        
        public decimal saldo { get; private set; }

        public void Depositar(decimal valor)
        {
            saldo +=valor;
        }

        public void Sacar(decimal valor)
        {
            saldo -=valor;
        }

    }
}
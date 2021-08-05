namespace EX4
{
    public class Investimento
    {
        private double valorInicial { get; set; }
        private double jurosMensais { get; set; }

        public void calcularLucro(int meses)
        {
            double retorno = ((valorInicial) * Math.Pow((1 + jurosMensais), meses)) - (valorInicial);

            if (meses < 6)
            {
                
            }
        }

    }
}
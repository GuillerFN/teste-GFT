namespace EX2
{
    public class HospedagemVIP : Hospedagem
    {
        public double valorAdcional;

        public void retorno(double valorAdicional, double valor)
        {
                double retorno = valor + valorAdicional;
        }
    }
}
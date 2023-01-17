namespace Desafio02.Form
{
    internal class ConverterForm
    {
        //Form para os dados recebidos da view
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double Valor { get; set; }
        public ConverterForm(string origem, string destino, string valor)
        {
            Origem = origem.ToUpper();
            Destino = destino.ToUpper();
            Valor = Double.Parse(valor);
        }
    }
}

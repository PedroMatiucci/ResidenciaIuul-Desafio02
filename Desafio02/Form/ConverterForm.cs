namespace Desafio02.Form
{
    internal class ConverterForm
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double Valor { get; set; }
        public ConverterForm(string origem, string destino, string valor)
        {
            Origem = origem;
            Destino = destino;
            Valor = Double.Parse(valor);
        }
    }
}

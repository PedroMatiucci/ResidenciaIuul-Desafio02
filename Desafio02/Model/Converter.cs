namespace Desafio02.Model
{
    internal class Converter
    {
        public string Origem { get; }
        public string Destino { get; }
        public double Valor { get; }
        public Converter(string origem, string destino, string valor)
        {
            Origem = origem;
            Destino = destino;
            Valor = Double.Parse(valor);
        }
    }
}

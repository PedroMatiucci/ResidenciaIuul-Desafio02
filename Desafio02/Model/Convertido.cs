namespace Desafio02.Model
{
    internal class Convertido
    {
        public double Taxa { get; }

        public double ValorOrigem { get; }
        public double ValorDestino { get; }

        public string Origem { get; }
        public string Destino { get; }


        public Convertido(double taxa, double valorOrigem, double valorDestino, string origem, string destino)
        {
            Taxa = taxa;
            ValorOrigem = valorOrigem;
            ValorDestino = valorDestino;
            Origem = origem;
            Destino = destino;
        }
    }
}


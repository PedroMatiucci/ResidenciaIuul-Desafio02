namespace Desafio02.Model
{
    internal class Conversao
    {
        public string Origem { get; }
        public string Destino { get; }
        public double Valor { get; }
        public Conversao(string origem, string destino, double valor)
        {
            Origem = origem;
            Destino = destino;
            Valor = valor;
        }
    }
}

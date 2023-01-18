using Desafio02.Model;

namespace Desafio02.Controller
{
    internal class RequestHtml
    {
        public async Task<string> GetJson(Conversao converter)
        {
            //Faz o request html
            string json = "";
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            string url = MontaUrl(converter);
            json = await client.GetStringAsync(url);
            return json;
        }

        internal static string MontaUrl(Conversao converter)
        {
            //Monta a url para o request com os dados fornecidos na view
            return $"https://api.exchangerate.host/convert?from={converter.Origem}&to={converter.Destino}&amount={converter.Valor}";
        }
    }
}

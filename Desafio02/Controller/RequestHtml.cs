using Desafio02.Model;

namespace Desafio02.Controller
{
    internal class RequestHtml
    {
        public async Task<string> GetJson(Converter converter)
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            string url = MontaUrl(converter);
            var json = await client.GetStringAsync(url);
            Console.WriteLine(json);
            return json;
        }

        internal static string MontaUrl(Converter converter)
        {
            //Melhorar ess codigo
            return $"https://api.exchangerate.host/convert?from={converter.Origem}&to={converter.Destino}&amount={converter.Valor}";
        }
    }
}

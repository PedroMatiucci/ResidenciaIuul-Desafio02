using Desafio02.Form;
using Desafio02.Model;
using Desafio02.View;

namespace Desafio02.Controller
{
    internal class Controlador
    {
        ViewPedeDados viewPedeDados = new ViewPedeDados();
        RequestHtml request = new RequestHtml();


        public async Task Start()
        {
            ConverterForm converterForm = viewPedeDados.PedeDados();
            Converter converter = new Converter(converterForm.Origem, converterForm.Destino, converterForm.Valor);
            var teste = await request.GetJson(converter);
            Console.WriteLine(teste);

        }
    }
}

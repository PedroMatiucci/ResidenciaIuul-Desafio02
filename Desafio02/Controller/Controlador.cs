using Desafio02.Form;
using Desafio02.Model;
using Desafio02.View;
using System.Text.Json;

namespace Desafio02.Controller
{
    internal class Controlador
    {
        ViewPedeDados viewPedeDados = new ViewPedeDados();
        ViewConversao viewConversao= new ViewConversao();
        RequestHtml request = new RequestHtml();


        public async Task Start()
        {
            ConverterForm converterForm = viewPedeDados.PedeDados();
            Converter converter = new Converter(converterForm.Origem, converterForm.Destino, converterForm.Valor);
            var json = await request.GetJson(converter);
            ConvertidoForm jsonConvertido = ConverteJson(json);
            Convertido conversao = CriaConversao(jsonConvertido);
            viewConversao.ExibeConversao(conversao);
        }

        public ConvertidoForm? ConverteJson(string json)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true};
            ConvertidoForm? jsonConvertido = null;
            try
            {
               jsonConvertido = JsonSerializer.Deserialize<ConvertidoForm>(json, options);
            }
            catch(Exception ex)
            {
                ViewErros.ExibeMensagemErroConversao();
            }
            return jsonConvertido;
        }

        public Convertido CriaConversao(ConvertidoForm form)
        {
            Convertido convertido = new Convertido(form.Rate, form.Amount ,form.Result, form.From, form.To);
            return convertido;
        }

        
    }

}
using Desafio02.Form;
using Desafio02.Model;
using Desafio02.View;
using System.Text.Json;

namespace Desafio02.Controller
{
    internal class Controlador
    {
        ViewPedeDados viewPedeDados = new ViewPedeDados();
        ViewConversao viewConversao = new ViewConversao();
        RequestHtml request = new RequestHtml();


        public async Task Start()
        {
            while (true)
            {
                DadosConversao converterForm = viewPedeDados.PedeDados();
                Conversao converter = new Conversao(converterForm.Origem, converterForm.Destino, converterForm.Valor);
                var json = await RequestJson(converter);
                DadosConvertido jsonConvertido = await ConverteJson(json);
                Convertido conversao = await CriaConversao(jsonConvertido);
                viewConversao.ExibeConversao(conversao);
            }

        }

        public async Task<DadosConvertido?> ConverteJson(string json)
        {
            //Deserealiza o json e  o transforma num objeto com os campos que temos interesse
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            DadosConvertido? jsonConvertido = null;
            try
            {
                jsonConvertido = JsonSerializer.Deserialize<DadosConvertido>(json, options);
            }
            catch (Exception ex)
            {
                //Mostra mensagem de erro casa falhe a conversao
                ViewErros.ExibeMensagemErroConversao();
                await Start();

            }
            return jsonConvertido;
        }

        public async Task<Convertido> CriaConversao(DadosConvertido form)
        {
            //Trasnforma o Form num objeto definitivo
            if (form == null)
            {
                ViewErros.ExibeMensagemErroConversao();
                await Start();
            }

            Convertido convertido = new Convertido(form.Rate, form.Amount, form.Result, form.From, form.To);
            return convertido;
        }

        public async Task<string> RequestJson(Conversao converter)
        {
            //Faz o request html 
            string json = "";
            try
            {
                json = await request.GetJson(converter);
            }
            catch (Exception ex)
            {
                //Mensagem de erro caso a rede falhe
                ViewErros.ExibeMensagemErroRede();
                await Start();
            }
            return json;
        }


    }

}
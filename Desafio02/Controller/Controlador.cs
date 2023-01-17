using Desafio02.Form;
using Desafio02.Model;
using Desafio02.View;
using System;
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
            ConverterForm converterForm = viewPedeDados.PedeDados();
            Converter converter = new Converter(converterForm.Origem, converterForm.Destino, converterForm.Valor);
            var json = await RequestJson(converter);
            ConvertidoForm jsonConvertido = await ConverteJson(json);
            Convertido conversao = await CriaConversao(jsonConvertido);
            viewConversao.ExibeConversao(conversao);
            await Start();
        }

        public async Task<ConvertidoForm?> ConverteJson(string json)
        {
            //Deserealiza o json e  o transforma num objeto com os campos que temos interesse
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            ConvertidoForm? jsonConvertido = null;
            try
            {
                jsonConvertido = JsonSerializer.Deserialize<ConvertidoForm>(json, options);
            }
            catch (Exception ex)
            {
                //Mostra mensagem de erro casa falhe a conversao
                ViewErros.ExibeMensagemErroConversao();
                await Start();

            }
            return jsonConvertido;
        }

        public async Task<Convertido> CriaConversao(ConvertidoForm form)
        {
            //Trasnforma o Form num objeto definitivo
            if(form == null)
            {
                ViewErros.ExibeMensagemErroConversao();
                await Start();
            }
           
            Convertido convertido = new Convertido(form.Rate, form.Amount, form.Result, form.From, form.To);
            return convertido;
        }

        public async Task<string> RequestJson(Converter converter)
        {
            //Faz o request html 
            string json = "";
            try
            {
                json = await request.GetJson(converter);
            }
            catch(Exception ex) 
            {
                //Mensagem de erro caso a rede falhe
                ViewErros.ExibeMensagemErroRede();
                await Start();
            }
            return json;
        }


    }

}
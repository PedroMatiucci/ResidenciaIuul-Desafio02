using Desafio02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02.View
{
    internal class ViewConversao
    {
        public void ExibeConversao(Convertido convertido)
        {
            //Exibe o valor convertido
            //Formata os valores para o estilo certo
            string origemFormatado = String.Format("{0:0.00}", convertido.ValorOrigem);
            string destinoFormatado = String.Format("{0:0.00}", convertido.ValorDestino);
            string taxaFormatada = String.Format("{0:0.000000}", convertido.Taxa);
            Console.WriteLine("{0} {1} => {2} {3}", convertido.Origem, origemFormatado, convertido.Destino, destinoFormatado);
            Console.WriteLine("Taxa: {0}", taxaFormatada);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02.View
{
    internal class ViewErros
    {

        //Clase responsavel pelas mensagens de erro
        public static void ExibeMensagemErroValor()
        {
            Console.WriteLine("\nErro: Insira Um Valor Maior que zero");
        }
        public static void ExibeMensagemErroValorInvalido()
        {
            Console.WriteLine("\nErro: Insira Um Valor Valido");
        }

        public static void ExibeMensagemErroMoedaCaracteres()
        {
            Console.WriteLine("\nErro: A Moeda Precisa Ter 3 Caracteres");
        }

        internal static void ExibeMensagemErroMoedasIguais()
        {
            Console.WriteLine("\nErro:As Moedas Precisam Ser Diferentes");
        }

        internal static void ExibeMensagemErroConversao()
        {
            Console.WriteLine("\nErro:A Conversao Falhou, Verifique os valores e tente novamente");
        }


        internal static void ExibeMensagemErroRede()
        {
            Console.WriteLine("\nErro:Verifique sua conexao e tente novamente");
        }
    }
}

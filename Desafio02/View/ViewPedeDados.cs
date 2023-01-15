using Desafio02.Form;

namespace Desafio02.View
{
    internal class ViewPedeDados
    {

        internal ConverterForm PedeDados()
        {
            string origem = PedeMoedaOrigem();
            string destino = PedeMoedaDestino();
            string valor = PedeValor();
            VerificaMoedasIguais(origem, destino);
            ConverterForm converterForm = new ConverterForm(origem, destino, valor);
            return converterForm;
        }

        private string PedeMoedaOrigem()
        {
            string input;
            do
            {
                Console.Write("Moeda Origem: ");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    System.Environment.Exit(1);
            } while (!ValidaMoeda(input));
            return input;
        }

        private string PedeMoedaDestino()
        {
            string input;
            do
            {
                Console.Write("Moeda Destino: ");
                input = Console.ReadLine();
            } while (!ValidaMoeda(input));
            return input;
        }

        private string PedeValor()
        {
            string input;
            do
            {
                Console.Write("Valor: ");
                input = Console.ReadLine();
            } while (!ValidaValor(input));
            return input;
        }

        internal static bool ValidaMoeda(string moeda)
        {
            if (string.IsNullOrEmpty(moeda))
            {
                ViewErros.ExibeMensagemErroMoedaCaracteres();
                return false;
            }
            if (moeda.Length != 3)
            {
                ViewErros.ExibeMensagemErroMoedaCaracteres();
                return false;
            }
            return true;
        }

        internal static bool ValidaValor(string valor)
        {
            double valorConvertido;
            try
            {
                valorConvertido = Double.Parse(valor);
            }
            catch (System.FormatException)
            {
                ViewErros.ExibeMensagemErroValorInvalido();
                return false;
            }
            if (valorConvertido <= 0)
            {
                ViewErros.ExibeMensagemErroValor();
                return false;
            }
            return true;
        }

        internal void VerificaMoedasIguais(string moedaOrigem, string moedaDestino)
        {
            if (moedaDestino.ToUpper() == moedaOrigem.ToUpper())
            {
                ViewErros.ExibeMensagemErroMoedasIguais();
                PedeDados();
            }
        }

    }
}

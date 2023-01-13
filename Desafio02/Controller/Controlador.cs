using Desafio02.Model;
using Desafio02.View;

namespace Desafio02.Controller
{
    internal class Controlador
    {
        ViewPedeDados viewPedeDados = new ViewPedeDados();
        public void Start()
        {
            viewPedeDados.PedeDados();
        }

        public void CriaConverter(string origem, string destino, string valor)
        {
            Converter objConverter = new Converter(origem, destino, valor);
        }
    }
}

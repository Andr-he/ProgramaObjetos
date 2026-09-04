using Microsoft.AspNetCore.Mvc;

namespace WebApiExercioRevisaoLogica.Controllers
{
    public class Exercicio5SistemaDescontoLojaController : Controller
    {
        [HttpPost("SistemaDescontoLoja")]
        public string SistemaDescontoLoja(double valorCompra, string clinteCadastrado)
        {
            //Variaveis
            double compraValor;
            string cadastradoCliente;
            int percentualDesconto;
            double valorDesconto;
            double valorFinal;


            //Entrada
            compraValor = 0;
            cadastradoCliente = "";
            percentualDesconto = 0;
            valorDesconto = 0;
            valorFinal = 0;


            //Processo
            if (compraValor < 500)
            {
                valorFinal = compraValor* 1.05;
                valorDesconto = compraValor * 0.05;
                percentualDesconto = 5;
                if (cadastradoCliente == "SIM")
                {
                    valorFinal = compraValor * 1.1;
                    valorDesconto = compraValor * 0.1;
                    percentualDesconto = 10;
                }
            }
            else if ()
            return "";
        }
    }
}

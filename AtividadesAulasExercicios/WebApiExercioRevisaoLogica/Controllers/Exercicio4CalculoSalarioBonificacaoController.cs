using Microsoft.AspNetCore.Mvc;

namespace WebApiExercioRevisaoLogica.Controllers
{
    public class Exercicio4CalculoSalarioBonificacaoController : Controller
    {
        [HttpPost("SalarioBonificacao")]
        public string SalarioBonificacao(Double salarioFuncionario, int tempoEmpresa)
        {
            //Variaveis
            double salario1;
            double salarioTotal;
            int anosEmpresa;
            double valorBonificacao;
            int percentualBonificacao;

            //Entrada
            salario1 = salarioFuncionario;
            anosEmpresa = tempoEmpresa;
            valorBonificacao = 0;
            salarioTotal = 0;
            percentualBonificacao = 0;



            if (salario1 < 2000)
            {
                percentualBonificacao = 20; 
                salarioTotal = salario1 * 1.20;
                valorBonificacao = salario1 * 0.2;
                if (anosEmpresa > 10)
                {
                    percentualBonificacao = 25;
                    salarioTotal = salario1 * 1.25;
                    valorBonificacao = salario1 * 0.25;
                }
            }
            else if ((salario1 >= 2000) && (salario1 <= 5000))
            {
                percentualBonificacao = 10;
                salarioTotal = salario1*1.10 ;
                valorBonificacao = salario1 * 0.1;
                if (anosEmpresa > 10)
                {
                    percentualBonificacao = 15;
                    salarioTotal = salario1 * 1.15;
                    valorBonificacao = salario1 * 0.15;
                }
            }
            else if (salario1 > 5000)
            {
                percentualBonificacao = 5;
                salarioTotal = salario1 * 1.05;
                valorBonificacao = salario1 * 0.05;
                if (anosEmpresa > 10)
                {
                    percentualBonificacao = 10;
                    salarioTotal = salario1 * 1.10;
                    valorBonificacao = salario1 * 0.1;
                }
            }


             return $"Percentual de bonificação: {percentualBonificacao}%\r\nValor da bonificação: {valorBonificacao:F2}\r\n+" +
                $"Salário Final: R${salarioTotal:F2}";
        }
    }
}

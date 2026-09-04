using Microsoft.AspNetCore.Mvc;

namespace WebApiExercioRevisaoLogica.Controllers
{
    public class Exercicio2ClassificacaoFaixaEtariaController : Controller
    {
        [HttpGet("ClassificacaoFaixaEtaria")]
        public string ClassificacaoFaixaEtaria(int idadePessoa)
        {
            //Vaariaveis
            int idade;
            string clasificacaoFaixaEtaria = "", situacaoVoto = "";


            //entrada

            idade = idadePessoa;

            //processo
            if ((idade > 0) && (idade < 13))
            {
                clasificacaoFaixaEtaria = "Classificação: CRIANÇA";
                situacaoVoto = "VOTO PROIBIDO";
            }
            if ((idade >= 13) && (idade <= 17))
            {
                clasificacaoFaixaEtaria = "Classificação: ADOLECENTE";
                if ((idade >= 16) && (idade <= 17))
                {
                    situacaoVoto = "VOTO FACILITATIVO";
                }
                else
                {
                    situacaoVoto = "VOTO PROIBIDO";
                }
            }
            else if ((idade > 17) && (idade <= 59))
            {
                clasificacaoFaixaEtaria = "Classificação:ADULTO";
                situacaoVoto = "VOTO OBRIGATÓRIO";
            }
            else
            {
                clasificacaoFaixaEtaria = "Classificação:IDOSO";
                situacaoVoto = "VOTO FACULTATIVO";
            }
            
            return $"A idade da pessoa é: {idade} anos\r\n{clasificacaoFaixaEtaria}\r\n +" +
                $"Situação do Voto: {situacaoVoto}";
        }
    }
}

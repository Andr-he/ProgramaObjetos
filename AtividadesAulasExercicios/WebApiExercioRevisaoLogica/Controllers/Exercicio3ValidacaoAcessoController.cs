using Microsoft.AspNetCore.Mvc;

namespace WebApiExercioRevisaoLogica.Controllers
{
    public class Exercicio3ValidacaoAcessoController : Controller
    {
        [HttpPost("ValidacaoAcesso")]
        public string ValidacaoAcesso(int idadeUsuario, string senhaUsuario, string contaAtivau)
        {
            //Variáveis
            int idade;
            string senha, contaAtiva, resultadoPermissao;
            //Entrada

            idade = idadeUsuario;



            senha = senhaUsuario;



            contaAtiva = contaAtivau;

            //Processo
            if ((idade >= 18) && (senha == "Senh@21082026") && (contaAtiva == "SIM"))
            {
                resultadoPermissao = "Acesso Permitido";
            }
            else
            {
                resultadoPermissao = "Acesso Negado";
            }

            //SAIDA
           
            return $"{resultadoPermissao}";
        }
    }
}

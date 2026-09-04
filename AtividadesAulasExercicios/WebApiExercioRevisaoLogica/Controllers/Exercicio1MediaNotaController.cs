using Microsoft.AspNetCore.Mvc;

namespace WebApiExercioRevisaoLogica.Controllers
{
    public class Exercicio1MediaNotaController : Controller
    {
        [HttpPost("MediaNotaAlunos")]
        public string MediaNotaAlunos(double nota1Aluno, double nota2Aluno, int faltaAluno)
        {
            //Variaveis

            double nota1, nota2, mediaNota;
            int falta;
            string situacaoAluno = "";

            nota1 = nota1Aluno;
            nota2 = nota2Aluno;
            falta = faltaAluno;

            //processo
            mediaNota = (nota1 + nota2) / 2;

            if ((mediaNota >= 7) && (falta <= 10))
            {
                situacaoAluno = "Aluno aprovado";
            }
            else if ((mediaNota < 7) && (falta <= 10))
            {
                situacaoAluno = "Aluno reprovado";
            }
            else if (falta > 10)
            {
                situacaoAluno = "Aluno Reprovado por faltas";
            }
            //Saída 
            return $"Média de notas do Aluno:{mediaNota}\r\nSituação: {situacaoAluno}";
        }
    }
}

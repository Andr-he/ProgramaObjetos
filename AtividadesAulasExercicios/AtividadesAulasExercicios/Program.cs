//Variaveis
using System.ComponentModel.Design;

double nota1, nota2, mediaNota; 
int falta;
string situacaoAluno = "";

//entrada
Console.WriteLine("Informe a nota 1º do aluno");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a nota 2º do aluno");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o número de faltas do aluno");
falta = Convert.ToInt32(Console.ReadLine());

//processo
mediaNota = (nota1 +  nota2) / 2;

if ((mediaNota >= 7) && (falta  <= 10))
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
Console.WriteLine($"Média de notas do aluno: {mediaNota}");
Console.WriteLine($"Situação: {situacaoAluno}");


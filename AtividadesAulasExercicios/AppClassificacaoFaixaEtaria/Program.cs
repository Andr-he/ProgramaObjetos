//Vaariaveis
int idade;
string clasificacaoFaixaEtaria = "" , situacaoVoto = "";


//entrada
Console.WriteLine("Informe a idade da pessoa");
idade = Convert.ToInt32(Console.ReadLine());

//processo
if ((idade > 0 ) && (idade < 13))
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
Console.WriteLine($"A idade da pessoa é:{idade} anos");
Console.WriteLine(clasificacaoFaixaEtaria);
Console.WriteLine($"Situação do Voto:{situacaoVoto}");

//Variáveis
int idade;
string senha, contaAtiva, resultadoPermissao;
//Entrada
Console.WriteLine("Informe a idade do usuário");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a senha do usuário");
senha = Console.ReadLine();

Console.WriteLine("Informe a conta do usuário esta ativa - (SIM OU NÃO)");
contaAtiva = (Console.ReadLine().ToUpper());

if ((idade >= 18) && (senha == "Senh@21082026") && (contaAtiva == "SIM"))
{
    resultadoPermissao = "Acesso Permitido";
}
else
{
    resultadoPermissao = "Acesso Negado";
}

//SAIDA
Console.WriteLine(resultadoPermissao);
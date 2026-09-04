double peso, altura, imc;
string classificacaoImc;
Console.WriteLine("informe seu peso");
peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("informe sua altura");
altura = Convert.ToDouble(Console.ReadLine());

imc = peso / Math.Pow(altura,2);

if (imc <= 18.9)
{
    classificacaoImc = "Pessoa abaixo do peso";
} else if ((imc >= 18.9) && (imc <= 24.9))
{
    classificacaoImc = "Pessoa com peso normal";
} else if ((imc > 24.9) && (imc <= 29.9))
{
    classificacaoImc = "Pessoa com sobrepeso";
}
else
{
    classificacaoImc = "OBESO";
}
Console.WriteLine("Classificação IMC");
Console.WriteLine($"O IMC da pessoa é:{imc}");
Console.WriteLine($"Classificação do IMC: {classificacaoImc}");


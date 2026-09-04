int numero, SomaNumero;
SomaNumero = 0;
Console.WriteLine("Informe um número para acumular ou 0 para saber a soma Total");
numero = Convert.ToInt32(Console.ReadLine());
while (numero != 0)
{
    SomaNumero = numero + SomaNumero;
    Console.WriteLine("Informe um número para acumular ou 0 para saber a soma Total");
    numero = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($" A soma dos 5 números informados é {SomaNumero}");

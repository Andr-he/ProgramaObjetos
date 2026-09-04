int numero, contador, somaNumero;
contador = 1;
somaNumero = 0;
while (contador <= 5)
{
    Console.WriteLine("Informe um número");
    numero = Convert.ToInt32(Console.ReadLine());
    somaNumero = numero + somaNumero;
    contador = contador + 1;
}
Console.WriteLine($"A soma dos 5 números informados é {somaNumero}");

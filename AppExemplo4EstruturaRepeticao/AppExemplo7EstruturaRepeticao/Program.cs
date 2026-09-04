int numero, somaNumero;
somaNumero = 0;
do
{
    Console.WriteLine("Informe um número para acumular ou 0 para saber a soma Total");
    numero = Convert.ToInt32(Console.ReadLine());
    somaNumero = numero + somaNumero;
} while(numero!=0);
Console.WriteLine($" A soma dos 5 números informados é {somaNumero}");

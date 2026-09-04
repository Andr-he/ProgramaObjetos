double nota, mediaNota, somaNota;
int contador;
contador = 1;
somaNota = 0;
do
{
    Console.WriteLine($"Informe a {contador}º nota de 5 notas possíveis");
    nota = Convert.ToDouble(Console.ReadLine());
    somaNota = (somaNota + nota);
    //contador = contador + 1
    contador += 1;
} while (contador <= 5);
mediaNota = somaNota / 5;
Console.WriteLine($"A média das 5 notas informadas é {mediaNota}");

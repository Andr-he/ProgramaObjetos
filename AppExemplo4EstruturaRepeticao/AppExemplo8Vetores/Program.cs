double[] notas = new double[5];
for  (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe a {i+1} nota");
    notas[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("As notas informadas pelo usuário são: ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Vetor notas[{i}] = {notas[i]}");
}
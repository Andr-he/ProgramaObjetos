double raio, pi, areaCircuferencia;
Console.WriteLine("Informe o raio da circuferência");
raio = Convert.ToDouble(Console.ReadLine());
//pi = 3.1416;
areaCircuferencia = Math.PI * raio * raio;
Console.WriteLine("A área da circuferência é " + Math.Round(areaCircuferencia,2));
Console.ReadKey();

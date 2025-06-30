int jogadas;
 
Console.Clear();
Console.WriteLine("--- Surpresinha ---\n");
 
Console.Write("Quantas jogadas? ");
 if (!int.TryParse(Console.ReadLine(), out  jogadas) || jogadas <= 0)
   {
      Console.WriteLine("Número inválido.");
            return;
   }
 
        var random = new Random();

for (int i = 0; i < jogadas; i++)
{
  var numeros = new HashSet<int>();

  while (numeros.Count < 6)
    numeros.Add(random.Next(1, 61));

  var resultado = numeros.OrderBy(n => n);
  Console.WriteLine(string.Join(" - ", resultado));
}

Console.Write("Precione uma tecla para finalizar...");
Console.ReadKey();

// 1. Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.

List<int> numeros = new List<int> {1, 2, 3, 2, 1, 3, 7, 8, 9, 10};

var numerosUnicos = numeros.Distinct();

Console.WriteLine("Números únicos na lista: ");
foreach (var numero in numerosUnicos)
{
    Console.Write(numero + " ");
}
Console.WriteLine();

// 2. Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.

List<int> num = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

var numerosPares = num.Where(numero => numero % 2 == 0);

Console.WriteLine("Números Pares: ");
foreach (var pares in numerosPares)
{
    Console.Write(pares + " ");
}
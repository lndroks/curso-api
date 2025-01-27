//1) Escrever um programa que faça uma requisição para a API de games CheapShark e mostre
//na tela a lista de promoções cadastrada na ferramenta (Você pode utilizar o endpoint:
//https://www.cheapshark.com/api/1.0/deals).

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}

//2) Escrever um programa que solicite dois números a e b lidos do teclado e realize a
//divisão de a por b. Caso essa operação não seja possível, mostrar uma mensagem no
//console que deixe claro o erro ocorrido.

Console.Write("Digite o A:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Digite o B:");
int b = int.Parse(Console.ReadLine()!);

try 
{
    Console.WriteLine($"\nA/B = {a/b} ");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: na matemática não é permitida a divisão por 0.");
}

//3) Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente.
//Tratar a exceção apropriada.

try
{
    List<int> numeros = new List<int> { 1, 2, 3};
    Console.WriteLine($"Elemento no índice 5: {numeros[5]}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

//4) Criar uma classe simples com um método e chame esse método em um objeto nulo.
//Tratar a exceção de método em objeto nulo.
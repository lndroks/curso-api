using System.Text.Json.Serialization;

namespace Modulo2;

public class Filme
{
    [JsonPropertyName("title")]
    public string? Nome { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("crew")]
    public string? Elenco { get; set; }

    [JsonPropertyName("imDbRating")]
    public string? Nota { get; set; }

    public void ExibirDetalhesFilme()
    {
        Console.WriteLine("==== FILME ====");
        Console.WriteLine($"Título: {Nome}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Elenco: {Elenco}");
        Console.WriteLine($"Nota: {Nota}");
    }
}
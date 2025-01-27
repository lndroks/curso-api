using System.Text.Json.Serialization;

namespace Modulo2;

public class Livro
{
    [JsonPropertyName("titulo")]
    public string? Titulo { get; set; }

    [JsonPropertyName("autor")]
    public string? Autor { get; set; }

    [JsonPropertyName("ano_publicacao")]
    public int? Ano { get; set; }

    [JsonPropertyName("genero")]
    public string? Genero { get; set; }

    public void ExibirDetalhesLivro()
    {
        Console.WriteLine();
        Console.WriteLine("==== LIVRO ====");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Gênero: {Genero}");
    }
}
using System.Text.Json.Serialization;

namespace Modulo2;

public class Pais
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }

    [JsonPropertyName("capital")]
    public string? Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int? Populacao { get; set; }

    [JsonPropertyName("continente")]
    public string? Continente { get; set; }
    
    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }

    public void ExibirDetalhesPais()
    {
        Console.WriteLine();
        Console.WriteLine("==== PAÍS ====");
        Console.WriteLine($"Título: {Nome}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"População: {Populacao}");
        Console.WriteLine($"Continete: {Continente}");
        Console.WriteLine($"Idioma: {Idioma}");
    }
}
using System.Text.Json.Serialization;

namespace Modulo2;

public class Carro
{
    [JsonPropertyName("marca")]
    public string? Marca { get; set; }

    [JsonPropertyName("modelo")]
    public string? Modelo { get; set; }

    [JsonPropertyName("ano")]
    public int? Ano { get; set; }

    [JsonPropertyName("tipo")]
    public string? Tipo { get; set; }

    public void ExibirDetalhesCarro()
    {
        Console.WriteLine();
        Console.WriteLine("==== CARRO ====");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Tipo: {Tipo}");
    }
}
using Modulo2;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string filmesAPI = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        string PaisAPI = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        string CarroAPI = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        string LivroAPI = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");

        var filmes = JsonSerializer.Deserialize<List<Filme>>(filmesAPI)!;
        filmes[0].ExibirDetalhesFilme();
        var paises = JsonSerializer.Deserialize<List<Pais>>(PaisAPI)!;
        paises[0].ExibirDetalhesPais();
        var carros = JsonSerializer.Deserialize<List<Carro>>(CarroAPI)!;
        carros[0].ExibirDetalhesCarro();
        var livros = JsonSerializer.Deserialize<List<Livro>>(LivroAPI)!;
        livros[0].ExibirDetalhesLivro();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}
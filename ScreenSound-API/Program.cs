using ScreenSound_API.Modelos;
using System.Text.Json;
using ScreenSound_API.Filtros;

using (HttpClient client = new HttpClient())

{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListasDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"{ex.Message}");
    }
}
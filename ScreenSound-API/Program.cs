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
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        
        var musicasPreferidasDoLeandro = new MusicasPreferidas("Leandro");
        musicasPreferidasDoLeandro.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoLeandro.AdicionarMusicasFavoritas(musicas[377]);
        musicasPreferidasDoLeandro.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDoLeandro.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDoLeandro.AdicionarMusicasFavoritas(musicas[1467]);
        
        musicasPreferidasDoLeandro.ExibirMusicasFavoritas();

        musicasPreferidasDoLeandro.GerarArquivoJson();
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"{ex.Message}");
    }
}
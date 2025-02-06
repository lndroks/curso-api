using System.Linq;
using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica =>musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicaDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicaDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    
    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas)
    {
        var musicaPorTonalidade = musicas.Where(musica => musica.Tonalidade!.Equals("C#")).ToList();
        Console.WriteLine("Exibindo músicas por tonalidade C#");
        Console.WriteLine();
        foreach (var musica in musicaPorTonalidade)
        {
            Console.WriteLine($"- {musica.Nome}, {musica.Tonalidade}");
        }
    }
}
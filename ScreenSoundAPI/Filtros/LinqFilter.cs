using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.
            Select(generos => generos.Genero).
            Distinct().
            ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.
            Where(musica => musica.Genero!.Contains(genero)).
            Select(musica => musica.Artista).Distinct().
            ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrasAsMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        // var musicasDoArtista = musicas.
        //     Where(musica => musica.Artista!.Equals(nomeDoArtista)).
        //     Select(musica => musica.Nome).
        //     Distinct().
        //     ToList();
        var musicasDoArtista = musicas.
            Where(musica => musica.Artista!.Equals(nomeDoArtista)).
            ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarAsMusicasPorAno(List<Musica> musicas, string ano)
    {
        var musicasPorAno = musicas.
            Where(musica => musica.Ano!.Equals(ano)).
            Select(musica => musica.Nome).
            Distinct().
            ToList();
        Console.WriteLine(ano);
        foreach (var musica in musicasPorAno)
        {
            Console.WriteLine($"- {musica}");
        }
        Console.WriteLine($"Quantidade de músicas: {musicasPorAno.Count}");
    }

    public static void FiltrarAsMusicasNaTonalidadeDoSustenido(List<Musica> musicas)
    {
        var musicasNaTonalidadeDoSustenido = musicas.
            Where(musica => musica.Tonalidade.Equals("C#")).
            Select(musica => musica.Nome).
            Distinct().
            ToList();
        Console.WriteLine("Músicas na tonalidade de C#: ");
        foreach (var musica in musicasNaTonalidadeDoSustenido)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
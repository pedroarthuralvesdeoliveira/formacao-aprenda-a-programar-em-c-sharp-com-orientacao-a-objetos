using System.Text.Json;
using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        // musicas[0].ExibirDetalhesDaMusica();
        LinqFilter.FiltrarAsMusicasNaTonalidadeDoSustenido(musicas);
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        // LinqFilter.FiltrasAsMusicasDeUmArtista(musicas, "Michel Teló");
        // LinqFilter.FiltrarAsMusicasPorAno(musicas, "2014");
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // var musicasPreferidasDoPedro = new MusicasPreferidas("Pedro");
        // musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[0]);
        // musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[2]);
        // musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[3]);
        // musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[4]);
        // musicasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[5]);
        
        //musicasPreferidasDoPedro.ExibirMusicasFavoritas();
        //musicasPreferidasDoPedro.GerarArquivoJson();
        //musicasPreferidasDoPedro.GerarDocumentoTXTComAsMusicasFavoritas();
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}
using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    
    [JsonPropertyName("duration_ms")] 
    public int Duracao { get; set; }
    
    [JsonPropertyName("genre")] 
    public string? Genero { get; set; }
    
    [JsonPropertyName("year")]
    public string? Ano { get; set; }
    
    [JsonPropertyName("key")]
    public int Key { get; set; }

    private string[] Tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    public string Tonalidade
    {
        get
        {
            return Tonalidades[Key];
        } 
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duracao em segundos: {Duracao / 1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
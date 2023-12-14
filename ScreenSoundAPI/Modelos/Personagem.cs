using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos;

internal class Personagem
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    
    [JsonPropertyName("gender")] 
    public string? Genero { get; set; }
    
    [JsonPropertyName("culture")]
    public string? Culture { get; set; }
    
    public void ExibirDetalhesDoPersonagem()
    {
        Console.WriteLine($"Personagem: {Nome}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Cultura: {Culture}");
    }
}
using System.Text.Json;

namespace ScreenSoundAPI.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasPreferidas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasPreferidas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas - {Nome}");
        foreach (var musica in ListaDeMusicasPreferidas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasPreferidas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo JSON {Path.GetFullPath(nomeDoArquivo)} foi criado com sucesso! ");
    }
    
    public void GerarDocumentoTXTComAsMusicasFavoritas()
    {
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
        {
            arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
            foreach (var musica in ListaDeMusicasPreferidas)
            {
                arquivo.WriteLine($"- {musica.Nome}");
            }
        }
        Console.WriteLine("txt gerado com sucesso!");
    }

}
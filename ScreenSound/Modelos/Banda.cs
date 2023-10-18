namespace ScreenSound.Modelos;

internal class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    public double Media
    {
        get
        {
            if (!Notas.Any())
            {
                return 0;
            }
            return Notas.Average(item => item.Nota);
        }
    }
    public string Nome { get; }
    private List<Album> Albuns = new List<Album>();
    private List<Avaliacao> Notas = new List<Avaliacao>();

    public void AdicionarAlbum(Album album)
    {
        Albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        Notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in Albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
        Console.WriteLine();
    }
}
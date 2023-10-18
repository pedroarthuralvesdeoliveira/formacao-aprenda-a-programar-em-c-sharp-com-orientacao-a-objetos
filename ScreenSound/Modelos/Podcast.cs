namespace ScreenSound.Modelos;

public class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Host { get; }
    public string Nome { get;}
    public int TotalEpisodios => Episodios.Count;
    private List<Episodio> Episodios = new List<Episodio>();

    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
        // TotalEpisodios += 1;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome} apresentado por {Host}");
        foreach (var episodio in Episodios)
        {
            Console.WriteLine($"Episódio: {episodio.Titulo}, com duração de {episodio.Duracao}");
        }
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
    }
}
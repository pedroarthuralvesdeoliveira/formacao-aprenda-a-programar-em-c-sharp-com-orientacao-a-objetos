namespace ScreenSound.Modelos;

internal class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);
    private List<Musica> Musicas = new List<Musica>(); 

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    // public float Duracao()
    // {
    //     Musicas.ForEach(musica => DuracaoTotal += musica.Duracao);
    //     return float.Round((DuracaoTotal / 60));
    // }

    public void VisualizarMusicas()
    {
        Musicas.ForEach(musica => musica.ExibirFichaTecnica());
    }
}
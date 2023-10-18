namespace ScreenSound.Modelos;

internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public Banda Artista { get; }

    public Genero Genero { get; set; }
    public string Descricao => $"A música {Nome} pertence à banda {Artista}.";
    public string Nome { get; }
    public bool Disponivel { get; set; }
    public int Duracao { get; set; }

    public void AdicionarGenero(Genero genero)
    {
        Genero = genero;
    }
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Gênero: {Genero.Nome}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano. ");
        }
        else
        {
            Console.WriteLine("Adquira o plano plus! ");
        }
        Console.WriteLine();
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"{Nome} - {Artista}");
    }
}
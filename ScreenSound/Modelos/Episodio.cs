namespace ScreenSound.Modelos;

public class Episodio
{
    public Episodio(string titulo, int duracao, int ordem = 1)
    {
        Titulo = titulo;
        Ordem += ordem;
        Duracao = duracao;
    }
    
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"#{Ordem} - {Titulo} ({Duracao}): {string.Join(", ", Convidados)}";
    public string Titulo { get; }
    public List<string> Convidados = new List<string>();

    public void AdicionarConvidados(string convidado)
    {
        Convidados.Add(convidado);
    }
}
/**
 * Banda dylanGossett = new Banda("Dylan Gossett");

Album albumDoDylanGossett = new Album("Beneath Oak Trees");

Genero generoUm = new Genero("Country");

Inicialização de propriedades não obrigatórias no construtor 
Musica musicaUm = new Musica(dylanGossett, "Coal")
{
    Disponivel = true,
    Duracao = 194
};
musicaUm.AdicionarGenero(generoUm);

Musica musicaDois = new Musica(dylanGossett, "Beneath Oak Trees");
musicaDois.Disponivel = true;
musicaDois.Duracao = 237;
musicaDois.AdicionarGenero(generoUm);

Musica musicaTres = new Musica(dylanGossett, "To Be Free");
musicaTres.Disponivel = true;
musicaTres.Duracao = 168;
musicaTres.AdicionarGenero(generoUm);

albumDoDylanGossett.AdicionarMusica(musicaUm);
albumDoDylanGossett.AdicionarMusica(musicaDois);
albumDoDylanGossett.AdicionarMusica(musicaTres);

albumDoDylanGossett.VisualizarMusicas();
dylanGossett.AdicionarAlbum(albumDoDylanGossett);

Console.WriteLine($"A duração do álbum é: {albumDoDylanGossett.DuracaoTotal}");

dylanGossett.ExibirDiscografia();

Episodio episodioUm = new Episodio("Como fazer um Loop em C#", 300);
episodioUm.AdicionarConvidados("Cristiano Ronaldo");
episodioUm.AdicionarConvidados("Messi");
episodioUm.AdicionarConvidados("Neymar");
Console.WriteLine(episodioUm.Resumo);

Episodio episodioDois = new Episodio("Como fazer um While em C#", 600);
episodioDois.AdicionarConvidados("Daniel");
episodioDois.AdicionarConvidados("João");
episodioDois.AdicionarConvidados("Jose");

Episodio episodioTres = new Episodio("Como fazer um Do While em C#", 120);
episodioTres.AdicionarConvidados("Asa");
episodioTres.AdicionarConvidados("Josias");
episodioTres.AdicionarConvidados("Barnabe");

Podcast theBest = new Podcast("O melhor jogador do mundo", "Marcelo");
theBest.AdicionarEpisodio(episodioUm);
theBest.AdicionarEpisodio(episodioDois);
theBest.AdicionarEpisodio(episodioTres);
theBest.ExibirDetalhes();
 */

using ScreenSound.Modelos;

Banda ira = new Banda("Ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(9));
ira.AdicionarNota(new Avaliacao(7));

Banda beatles = new Banda("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new ();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostrarBandasRegistradas();
            break;
        case 4:
            AvaliarUmaBanda();
            break;
        case 5:
            ExibirDetalhes();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void VoltarAoMenu()
{
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        Album album = new Album(tituloAlbum);
        banda.AdicionarAlbum(album);
        Console.WriteLine($"O álbum {album.Nome} de {banda.Nome} foi registrado com sucesso!");
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        VoltarAoMenu();
    }
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Banda banda = new Banda(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, banda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    VoltarAoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
        banda.AdicionarNota(nota);
        Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        VoltarAoMenu();
    }

}

void ExibirDetalhes()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {banda.Nome} é {banda.Media}.");
        banda.ExibirDiscografia();
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        VoltarAoMenu();
    }
}

ExibirOpcoesDoMenu();
using ScreenSound.Menus;
using ScreenSound.Modelos;

Banda ira = new Banda("Ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(9));
ira.AdicionarNota(new Avaliacao(7));

Banda beatles = new Banda("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new ();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);

void ExibirOpcoesDoMenu()
{
    Menu.ExibirLogo();
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
            MenuRegistrarBanda menuRegistrarBanda = new MenuRegistrarBanda();
            menuRegistrarBanda.Executar(bandasRegistradas);
            VoltarAoMenu();
            break;
        case 2:
            MenuRegistrarAlbum menuRegistrarAlbum = new MenuRegistrarAlbum();
            menuRegistrarAlbum.Executar(bandasRegistradas);
            VoltarAoMenu();
            break;
        case 3:
            MenuMostrarBandas menuMostrarBandas = new MenuMostrarBandas();
            menuMostrarBandas.Executar(bandasRegistradas);
            VoltarAoMenu();
            break;
        case 4:
            MenuAvaliarBanda menuAvaliarBanda = new MenuAvaliarBanda();
            menuAvaliarBanda.Executar(bandasRegistradas);
            VoltarAoMenu();
            break;
        case 5:
            MenuExibirDetalhes menuExibirDetalhes = new MenuExibirDetalhes();
            menuExibirDetalhes.Executar(bandasRegistradas);
            VoltarAoMenu();
            break;
        case -1:
            MenuSair.Executar();
            break;
        default:
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

ExibirOpcoesDoMenu();
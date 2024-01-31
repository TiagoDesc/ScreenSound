// ScreenSound 

string mensagemBoasVindas = "Boas vindas ao Screen Sound.";

void ExibirMensagem()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemBoasVindas);
    
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair\n");

    Console.Write("Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumericaEscolhida = int.Parse(opcaoEscolhida);

    if (opcaoNumericaEscolhida == 1)
    {
        Console.WriteLine("Você digitou a opção: " + opcaoNumericaEscolhida);
    }
}

ExibirMensagem();
ExibirOpcoesMenu();

// Criar uma variável chamada curso, e guarde nela o nome do curso estudado.
// Mostrar o conteúdo da variável curso no console.
// Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome.
// Mostrar na tela o nome dos instrutores do curso.

Console.WriteLine("************************************");
string curso = "C#: criando sua primeira aplicação C#: criando sua primeira aplicação";
Console.WriteLine(curso);
string nome = "Tiago";
string sobrenome = "Nobre.";
Console.WriteLine(nome + " " + sobrenome);
Console.WriteLine("Instrutores do curso: Guilherme Lima e Daniel Portugal.");  

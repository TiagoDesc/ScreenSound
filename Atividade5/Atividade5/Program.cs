// 1 - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

// 2 - Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.

// 3 - Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.

// 4 - Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.


Dictionary<string, List<double>> notaAlunos = new Dictionary<string, List<double>>();
notaAlunos["Tiago"] =  new List<double> {8.5, 10, 9.5 };
notaAlunos["Lionel Messi"] = new List<double> { 10, 10, 10 };

foreach (var aluno in notaAlunos)
{
    double soma = 0;
    for(int i = 0; i < aluno.Value.Count; i++)
    {
        soma += aluno.Value[i];
    }

    double media = soma / aluno.Value.Count;

    string mediaFormat = media.ToString("F2");

    Console.WriteLine($"A média das notas do {aluno.Key} é de: {mediaFormat}." );
    Console.Clear();
}

Dictionary<string, int> estoque = new Dictionary<string, int>
{
    
    {"Camisetas", 50 },
    {"Calças", 40 },
    {"Bermuda", 25 },
    {"Tênis", 100 },

};
Console.WriteLine("Digite o produto que você deseja e veja sua quantidade em estoque: ");
    string usuario = Console.ReadLine()!;

if (estoque.ContainsKey(usuario))
{
    Console.WriteLine($"Quantidade em estoque de {usuario}: {estoque[usuario]} unidades.");
}
else
{
    Console.WriteLine($"{usuario} não encontrado. Digite novamente.");
}

// 1 - Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

// 2 - Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

// 3 - Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

// 4 - Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.


void Calculo()
{
    double a = 10;
    float b = 2;

    double soma = a + b;
    double subtracao = a - b;
    double multiplicacao = a * b;
    double divisao = a / b;

    Console.WriteLine($"a + b = {soma}");
    Console.WriteLine($"a - b = {subtracao}");
    Console.WriteLine($"a * b = {multiplicacao}");
    Console.WriteLine($"a / b = {divisao}");    
    Console.WriteLine("***********************");
}

Calculo();

List<string > banda = new List<string>();
banda.Add("Onze: 20");
banda.Add("Gilsons");
banda.Add("Maneva");
banda.Add("Lagum");

Console.WriteLine("As bandas adiconadas foram: ");
foreach( string bandasAdc in banda)
{
    Console.WriteLine(bandasAdc);
}
Console.WriteLine("***********************");


List<int> numeros = new List<int>();
numeros.Add(16);
numeros.Add(10);
numeros.Add(20);
numeros.Add(57);
numeros.Add(12);

int soma = 0;
for(int i = 0; i < numeros.Count; i++)
{
    soma += numeros[i];
}

Console.WriteLine($"A soma dos números: {soma}");

Console.WriteLine("***********************");

List<int> pares = new List<int>();

Console.WriteLine("Digite o tamanho da lista: ");
string tamanho = Console.ReadLine()!;
int tamanhoEscolhido = int.Parse(tamanho);

for(int i = 0; i < tamanhoEscolhido; i++)
{
    Console.WriteLine("Digite um número: ");
    string numero = Console.ReadLine()!;
    int numeroEscolhido = int.Parse(numero);
    if(numeroEscolhido % 2 == 0) {
        Console.WriteLine(numeroEscolhido);
    }
}


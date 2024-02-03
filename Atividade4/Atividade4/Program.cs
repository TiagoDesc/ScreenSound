void Calculo()
{
    double a = 10;
    double b = 2;

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

List<string> bandas = new List<string>();
bandas.Add("Onze:20");
bandas.Add("Gilsons");
bandas.Add("Maneva");
bandas.Add("Lagum");

Console.WriteLine("As bandas adicionadas foram: ");
foreach (string bandaAdc in bandas)
{
    Console.WriteLine(bandaAdc);
}
Console.WriteLine("***********************");

List<int> numeros = new List<int> { 16, 10, 20, 57, 12 };

int somaNumeros = 0;
for (int i = 0; i < numeros.Count; i++)
{
    somaNumeros += numeros[i];
}

Console.WriteLine($"A soma dos números: {somaNumeros}");

Console.WriteLine("***********************");

List<int> pares = new List<int>();

Console.WriteLine("Digite o tamanho da lista de números pares: ");
string tamanhoPares = Console.ReadLine()!;
int tamanhoEscolhidoPares = int.Parse(tamanhoPares);

for (int i = 0; i < tamanhoEscolhidoPares; i++)
{
    Console.WriteLine("Digite um número: ");
    string numero = Console.ReadLine()!;
    int numeroEscolhido = int.Parse(numero);
    if (numeroEscolhido % 2 == 0)
    {
        pares.Add(numeroEscolhido);
    }
}

Console.WriteLine("Números pares adicionados à lista: ");
foreach (int numeroPar in pares)
{
    Console.WriteLine(numeroPar);
}

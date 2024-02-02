
using System;
using System.Collections.Generic;


    // 1 - Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
    // 2 - Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
    // 3 - Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
    // 4 - Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.


   //1
    int notaMedia = 8;

if(notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para a aprovação.");
}
    


    // 2, 3 , 4.
    List<string> linguagens = new List<string> {"C#", "Java", "JavaScript"};
    Console.WriteLine(linguagens[0]);
    Console.Write("Digite um número inteiro para obter a n-ésima posição da lista: ");
    int n;

    if (int.TryParse(Console.ReadLine(), out n))
    {
        
        if (n >= 0 && n < linguagens.Count)
        {
          
            Console.WriteLine("Elemento na n-ésima posição: " + linguagens[n]);
        }
        else
        {
            Console.WriteLine($"Número inválido. Certifique-se de escolher um valor entre 0 e {linguagens.Count - 1}.");
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro.");
    }






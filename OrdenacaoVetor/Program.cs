/*
 3- Faça um programa que leia 5 ou mais numeros(a escolha) numeros e guarde-os em um vetor e, faça as operações:

    1- Crie um novo vetor a partir do vetor original que esta ordenado e sem repetidos
    2- Crie um terceiro vetor a partir do segundo vetor e ordene ele ao contrario
    3- Não modifique o vetor original
 */

Console.WriteLine("=====Ordenação de vetor=====");

// Declaracao das variaveis
int size = 40, temp = 0, sizeVetorOrdenado = 0;

int[] vetor = new int[size];
int[] ordenado = new int[size];
int[] contrario = new int[size];


// Populando o vetor original e o segundo vetor(sem repetir)
for (int i = 0; i < size; i++)
{
    vetor[i] = new Random().Next(0, 5);

    if (i == 0)
    {
        ordenado[sizeVetorOrdenado] = vetor[i];
        sizeVetorOrdenado++;
    }
    else
    {
        bool repetido = false;
        for (int j = 0; j < sizeVetorOrdenado; j++)
        {
            if (ordenado[j] == vetor[i])
            {
                repetido = true;
            }
        }

        if (!repetido)
        {
            ordenado[sizeVetorOrdenado] = vetor[i];
            sizeVetorOrdenado++;
        }
    }
}

// Copiando o segundo vetor para o terceiro vetor
for (int i = 0; i < sizeVetorOrdenado; i++)
{
    contrario[i] = ordenado[i];
}


// Organizando o segundo vetor que nao possui itens ordenados
for (int i = 0; i < sizeVetorOrdenado; i++)
{
    for (int j = i + 1; j < sizeVetorOrdenado; j++)
    {
        if (ordenado[i] > ordenado[j])
        {
            temp = ordenado[i];
            ordenado[i] = ordenado[j];
            ordenado[j] = temp;
        }
    }
}



// Organizando o terceiro vetor para ser organizado ao contrario
for (int i = 0; i < sizeVetorOrdenado; i++)
{
    for (int j = i + 1; j < sizeVetorOrdenado; j++)
    {
        if (contrario[i] < contrario[j])
        {
            temp = contrario[i];
            contrario[i] = contrario[j];
            contrario[j] = temp;
        }
    }
}


Console.WriteLine("=============================");
Console.WriteLine("Vetor Original: ");
for (int i = 0; i < size; i++)
{
    //Console.WriteLine($"Array[{i}]={vetor[i]}");
    Console.Write($"{vetor[i]} ");

}


Console.WriteLine("\n=============================");
Console.WriteLine("Vetor Ordenado: ");
for (int i = 0; i < sizeVetorOrdenado; i++)
{
    Console.Write($"{ordenado[i]} ");
}


Console.WriteLine("\n=============================");
Console.WriteLine("Vetor Ordenado ao contrario: ");
for (int i = 0; i < sizeVetorOrdenado; i++)
{
    Console.Write($"{contrario[i]} ");
}


Console.WriteLine("\n=============================");
Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();

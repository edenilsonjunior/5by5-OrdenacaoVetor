/*
 3- Faça um programa que leia 5 numeros e guarde-os em um vetor e ordene-os de forma crescente em um novo vetor
 
 Logica empregada no programa:
    1- comparacao de pares do valor atual com o valor seguinte
    2- se o valor atual for maior que o valor seguinte, os valores sao trocados
    3- Percorrer o vetor no tanto de vezes conforme o tamanho dele
    
    A ordenacao é feita com dois for-loops, um loop externo que movimenta o indice inicial e
    um loop interno que compara começando desse indice inicial e indo até size-1
 */

Console.WriteLine("=====Ordenação de vetor=====");

int size = 10;
int[] vetor = new int[size];
int[] ordenado = new int[size];
int temp;


for (int i = 0; i < size; i++)
{
    vetor[i] = new Random().Next(0, 100);
    ordenado[i] = vetor[i];
}


// bubble sort mas que vem ordenando de tras pra frente
for (int i = 0; i < size; i++)
{
    for (int j = i + 1; j < size; j++)
    {
        if (ordenado[i] > ordenado[j])
        {
            temp = ordenado[i];
            ordenado[i] = ordenado[j];
            ordenado[j] = temp;
        }
    }
}


// selection sort
/*int menor;
for (int i = 0; i < size; i++)
{
    menor = i;

    for (int j = i + 1; j < size; j++)
    {
        if (ordenado[menor] > ordenado[j])
        {
            menor = j;
        }
    }

    temp = ordenado[i];
    ordenado[i] = ordenado[menor];
    ordenado[menor] = temp;

    for (int x = 0; x < size; x++)
    {
        Console.Write($"{ordenado[x]} ");
    }
    Console.WriteLine();
}*/


// bubble sort
/*bool trocou = true;
for (int i = 0; i < size && trocou; i++)
{
    trocou = false;
    for (int j = 0; j < size - (i + 1); j++)
    {
        if (ordenado[j] > ordenado[j + 1])
        {
            temp = ordenado[j];
            ordenado[j] = ordenado[j + 1];
            ordenado[j + 1] = temp;
            trocou = true;
        }
    }
}*/


Console.WriteLine("=============================");
Console.WriteLine("Vetor Original: ");
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Array[{i}]={vetor[i]}");
}


Console.WriteLine("=============================");
Console.WriteLine("Vetor Ordenado: ");
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Array[{i}]={ordenado[i]}");
}


Console.WriteLine("=============================");


Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();

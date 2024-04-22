/*
 3- Faça um programa que leia 5 numeros e guarde-os em um vetor e ordene-os de forma crescente em um novo vetor
 
 Logica empregada no programa:
    1- comparacao de pares do valor atual com o valor seguinte
    2- se o valor atual for maior que o valor seguinte, os valores sao trocados
    3- Percorrer o vetor no tanto de vezes conforme o tamanho dele
    
    A ordenacao é feita com dois for-loops, um loop externo que movimenta o indice inicial e
    um loop interno que compara começando desse indice inicial e indo até size-1
 */


Console.WriteLine("=====Numeros pares e impares=====");

int size = 5;
int[] vetor = new int[size];
int[] ordenado = new int[size];
int temp = 0;

for(int i = 0; i < size; i++)
{
    Console.Write($"Digite o {i+1}o numero: ");
    vetor[i] = int.Parse(Console.ReadLine());
}

for(int i = 0; i < size; i++)
{
    ordenado[i] = vetor[i]; 
}


// ordenacao do segundo vetor:
for(int i =0; i < size; i++)
{
    for (int j = 0; j < size-1; j++)
    {
        if(ordenado[j] > ordenado[j + 1])
        {
            temp = ordenado[j];
            ordenado[j] = ordenado[j + 1];
            ordenado[j+1] = temp;
        }
    }
}


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

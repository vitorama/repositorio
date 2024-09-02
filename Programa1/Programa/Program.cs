
//2 - Criar um laço para percorrer o vetor
//3 - Para cada posição gerar um vsalor aleatório
//4 - Ordenar o vetor (Bubble Sort)

// - Criar um vetor com 100 posições

int tamanho = 100;
int[] vetor = new int[tamanho];

// Criando um laço para percorrer o vetor
Random random = new Random();
for (int i = 0; i < vetor.Length; i++)

{
 // Criando um vetor com valores aleatórios

  vetor[i] = random.Next(1000);
  Console.Write(vetor[i] + ", ");
}

Console.WriteLine("\n");

// Ordenando os valores com o Bubble Sort
bool troca;
do
{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
{
    if(vetor[i] > vetor[i + 1])
    {
        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux; 
        troca = true;
    }
}

} while(troca);

Console.WriteLine("\n");

for (int i = 0; i < tamanho; i++)
{

    Console.Write(vetor[i] + " ");
}
  

// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.WriteLine("Укажите размеры матриц:");
int m = InputNumbers("Укажите число строк матрицы 1: ");
int n = InputNumbers("Введите число столбцов матрицы 1 и строк матрицы 2: ");
int p = InputNumbers("Введите число столбцов матрицы 2: ");

int[,] firstMartrix = new int[m, n];
CreateFillArray(firstMartrix);
Console.WriteLine("Матрица 1:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateFillArray(secomdMartrix);
Console.WriteLine("Матрица 2:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение матриц 1 и 2:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateFillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 99);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


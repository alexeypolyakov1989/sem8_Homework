// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rows, columns;
rows = columns = int.MaxValue; 
Random rnd = new Random();
rows = rnd.Next(2, 10);                      
columns = rnd.Next(2, 10);
Console.WriteLine("Задан двумерный массив:");
Console.WriteLine("");

double[,] array = new double[rows, columns];
CreateFillArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine("Массив с упорядоченными по убыванию элементами каждой строки:");
Console.WriteLine("");
PrintArray(array); 



void CreateFillArray(double[,] matrix2)
{   for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            matrix2[i, j] = Math.Round((rnd.NextDouble() * 200 - 100), 2); 
}
       
void PrintArray(double[,] matrix2)
{for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            Console.Write("{0, 10}", (array[i, j]).ToString("0.00"));
            Console.WriteLine("\n");
        } 
    Console.WriteLine();
}

void SortArray(double[,] matrix2)
{for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1) - 1; j++)
            for (int k = 0; k < matrix2.GetLength(1) - 1; k++)
                if (matrix2[i, k] < matrix2[i, k + 1]) 
                    (matrix2[i, k], matrix2[i, k + 1]) = (matrix2[i, k + 1], matrix2[i, k]);
}
// Задайте прямоугольный двумерный массив. \n" 
// + "Напишите программу, которая будет находить строку с наименьшей суммой элементов.");


Random rnd = new Random();
int rows = rnd.Next(2, 15);                      
int columns = rnd.Next(2, 15);
Console.WriteLine();
Console.WriteLine("Задан прямоугольный двумерный массив:");

double[,] array = new double[rows, columns];

CreateFillArray(array);
int numberRoW = RowArray(array, out numberRoW); 

PrintArray(array);
Console.WriteLine("В строке " + numberRoW + " наименьшая сумма элементов: \n"); 
PrintMinRow(array, numberRoW); 

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

int RowArray(double[,] matrix2, out int numberRoW)
{   int j; numberRoW = int.MinValue;
    double sum = 0; double minSum = double.MaxValue;
    for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (j = 0; j < matrix2.GetLength(1); j++) 
                sum += matrix2[i, j]; 
            if (sum < minSum) 
            {
                minSum = sum;
                numberRoW = i;
            }
        } 
    Console.WriteLine(); return numberRoW;
}

void PrintMinRow(double[,] matrix2, int row)
{   
    for (int j = 0; j < matrix2.GetLength(1); j++)
        Console.Write("{0, 10}", (matrix2[row, j]).ToString("0.00"));
    Console.WriteLine("\n");
}

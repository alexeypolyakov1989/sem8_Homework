// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая построчно выведет элементы и их индексы.

int rows, columns, layers;
rows = columns = layers = int.MaxValue; 
Random rnd = new Random();
while (rows * columns * layers > 90)         
{                                            
rows = rnd.Next(2, 10);                      
columns = rnd.Next(2, 10);                   
layers = rnd.Next(2, 10);
}

int[] elements = new int[90];
int[,,] array = new int[layers, rows, columns];

CreateFillArray(elements);
CreateFillArray2(array, elements);
PrintArray(array);

void CreateFillArray(int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        matrix[i] = 10 + i;
}

void CreateFillArray2(int[,,] matrix3, int[] matrix1)
{   int count = 0; int number;
    for (int k = 0; k < matrix3.GetLength(0); k++)
        for (int i = 0; i < matrix3.GetLength(1); i++)
            for (int j = 0; j < matrix3.GetLength(2); j++)
            {
                number = rnd.Next(0, 90); 
                while (matrix1[number] == 0)
                {
                    number = count;
                    count++;
                }
                matrix3[k, i, j] = matrix1[number];
                matrix1[number] = 0;
                count = 0;
            }
    
}

void PrintArray(int[,,] matrix)
{Console.Write("{");
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.Write($"{matrix[k, i, j]}");
                Console.Write($" ({k}, {i}, {j})");
                if (k == matrix.GetLength(0) -1 && i == matrix.GetLength(1) - 1 && j == matrix.GetLength(2) - 1) Console.Write("}");
                else Console.Write("; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
//Задайте двумерный массив. Напишите программу которая поменяет первую и последнюю строку массива

// Console.WriteLine("Введите число №1");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число №2");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = new int[rows, columns];

// for (int i = 0; i < result.GetLength(0); i++)
// {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//         result[i, j] = new Random().Next(0, 10);
//     }
// }


// for (int i = 0; i < result.GetLength(0); i++)
// {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//         Console.Write(result[i, j]);
//     }

//     Console.WriteLine();
// }

// for (int j = 0; j < result.GetLength(1); j++)
// {
//     int temp = result[0, j];
//     result[0, j] = result[result.GetLength(0) - 1, j];
//     result[result.GetLength(0) - 1, j] = temp;
// }

// Console.WriteLine("________________");

// for (int i = 0; i < result.GetLength(0); i++)
// {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//         Console.Write(result[i, j]);
//     }

//     Console.WriteLine();
// }


// Задача №2
// Задать двумерный массив.
// Написать программу которая заменяет строки на столбцы.
// В случае если это не возможно, программа должна вывести сообщение для пользователя.


//Home work
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите число №1");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[3, 4];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
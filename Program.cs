//Задайте двумерный массив. Напишите программу которая поменяет первую и последнюю строку массива

Console.WriteLine("Введите число №1");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число №2");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = new int[rows, columns];

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        result[i, j] = new Random().Next(0, 10);
    }
}


for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j]);
    }

    Console.WriteLine();
}

for (int j = 0; j < result.GetLength(1); j++)
{
    int temp = result[0, j];
    result[0, j] = result[result.GetLength(0) - 1, j];
    result[result.GetLength(0) - 1, j] = temp;
}

Console.WriteLine("________________");

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j]);
    }

    Console.WriteLine();
}
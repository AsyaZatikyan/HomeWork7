/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int [,] InitMatrix()
{
    int [,] result = new int [4,3];
    Random rnd = new Random();
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
           for (int j = 0; j < result.GetLength(1); j++)
           {
            result[i,j] = rnd.Next(1,10);
           } 
        }
    }
    return result;
}

void PrintMatrix(int [,]mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
           Console.Write($"{mat [i,j]} "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] arr = InitMatrix();
PrintMatrix(arr);

for (int j = 0; j < arr.GetLength(1); j++)
 {
     double sum = 0;
     for (int i = 0; i < arr.GetLength(0); i++)
     {
         sum += arr[i, j];
     }
     Console.Write($"{ sum / arr.GetLength(0)} ");
 }
 


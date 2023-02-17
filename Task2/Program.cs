/*
Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int[,] InitMatrix()
{
    int[,] result = new int[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(1, 10);
        }

    }

    return result;
}
void PrintMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetNumber(string massige)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massige);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не цифроб попробуйте еще раз: ");
        }
    }
    return result;
}



int rows = GetNumber("Введите индекс строки: ");
int colums = GetNumber("Введите индекс столбца: ");
int[,] numbers = InitMatrix();
PrintMatrix(numbers);
if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) 
Console.WriteLine(numbers[rows, colums]);
else 
Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
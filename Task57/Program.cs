/* Задача 57: Составить частотный словарь элементов двумерного
массива. Частотный словарь содержит информацию о том, сколько
раз встречается элемент входных данных. Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза   */
Console.Clear();
int[,] generate2DArray(int rowLength, int colLength, int start, int finish)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
void printHeadOfArray(int length)
{
    Console.Write("\t");
    for (int i = 0; i < length; i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}
void printArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "|\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("------------------------------");
}
int[] getFrequencyDictionary(int[,] array, int maxNumber)
{
    int[] result = new int[maxNumber];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[array[i, j]] += 1;
        }
    }
    return result;
}
void printFrequencyDictionary(int[] frequencyDictionary)
{
    for (int i = 0; i < frequencyDictionary.Length; i++)
    {
        if (frequencyDictionary[i] > 0)
        {
            Console.WriteLine($"{i} встречается {frequencyDictionary[i]} раз");
        }
    }
}
int[,] array = generate2DArray(5, 5, 0, 20);
printArray(array);
int[] frequencyDictionary = getFrequencyDictionary(array, 21);
printFrequencyDictionary(frequencyDictionary);

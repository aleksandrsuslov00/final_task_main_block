/*
Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();
string[] StrArrayOne = new string[5] {"Russia", "Denmark", "USA", "Japan", "UK"};
string[] StrArrayTwo = new string[StrArrayOne.Length];

Console.Write("Изначальный массив: ");
PrintArray(StrArrayOne);

void GenerateArrayOfStrings(string[] FirstArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if(FirstArray[i].Length <= 3)
        {
            SecondArray[count] = FirstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}"+" ");
    }
    Console.WriteLine();
}

GenerateArrayOfStrings(StrArrayOne, StrArrayTwo);
Console.Write("Преобразованный массив: ");
PrintArray(StrArrayTwo);

// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых <= 3 символа

void PrintArray(string[] arrayA)
{
    for (int i = 0; i < arrayA.Length; i++)
    {
        Console.Write($"{arrayA[i]} ");
    }
}

Console.WriteLine("Input array size: ");
int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
string[] array1 = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
for (int i = 0; i < n; i++)
{
    Console.Write("Input string No.{0}:\r\n    ", i + 1);
    array1[i] = Console.ReadLine(); //Заполняем его
}


void ThreeSymbols(string[] arrayA)
{
    string[] arrayB = new string[arrayA.Length];
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i].Length <= 3)
        {
            arrayB[count] = arrayA[i];
            count++;

        }
    }
    PrintArray(arrayA);
Console.Write(" --> ");
PrintArray(arrayB);
}

ThreeSymbols(array1);

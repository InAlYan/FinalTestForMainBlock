// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

System.Console.InputEncoding = System.Text.Encoding.Unicode; //Если не будет воспринимать русские символы

const int numberOfSymbols = 3;

int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string InputString(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] CreateStringArray(int size)
{
    string[] arr = new string[size];
    return arr;
}

void FillStringArrayManually(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = InputString($"Введите строку {i + 1} из {arr.Length}: ");
}

string[] FilterStringArrayByLength(string[] inArr, int strLength)
{
    // Вариант без Resize()
    // Считаем число строк у которых длина меньше либо равна определенного числа: (int strLength)
    int countFilteredStrings = 0;
    for (int i = 0; i < inArr.Length; i++)
        if (inArr[i].Length <= strLength)
            countFilteredStrings++;

    string[] outArr = CreateStringArray(countFilteredStrings); // Создаем выходной массив требуемой длины
    int outIndex = 0;

    // Наполняем выходной массив строками из входного массива у которых длина меньше либо равно определенного числа: (int strLength)
    for (int i = 0; i < inArr.Length; i++)
        if (inArr[i].Length <= strLength)
        {
            outArr[outIndex] = inArr[i];
            outIndex++;
        }

    return outArr;
}

void PrintStringArray(string[] arr)
{
    Console.Write("[");    
    for (int i = 0; i < arr.Length; i++)
        if (i == arr.Length -1)
            Console.Write($"\"{arr[i]}\"");
        else
            Console.Write($"\"{arr[i]}\", ");
    Console.WriteLine("]\n");
}

Console.Clear();


int arraySize = InputNumber("Введите размер массива: ");
string[] inintialArray = CreateStringArray(arraySize); // Создаем начальный массив строк
FillStringArrayManually(inintialArray); // Заполняем начальный массив строк вручную

PrintStringArray(inintialArray); // Печатаем начальный массив через свою функцию

string[] filteredArray = FilterStringArrayByLength(inintialArray, numberOfSymbols); // Получаем новый отфильтрованный массив

PrintStringArray(filteredArray); // Печатаем отфильтрованный массив через свою функцию
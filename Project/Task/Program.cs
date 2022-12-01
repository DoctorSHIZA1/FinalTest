int n = 3;
int size  = 6;
string[] arrayOne = new string[size];
Console.WriteLine($"Введите набор символов, обозначающих значение строкового элемента массива,{size} раз через Enter без пробелов");
FillArray(arrayOne);
//FillArrayRandomly(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine($"Новый массив, содержащий элементы,которыйе меньше либо равны (n):);
if (GetSazeOfSecondArrey(arrayOne) == 0)
    {
        Console.WriteLine("Искомых элементов строкового массива для переноса в новый массив не найдено");
    }
else
{
    string[] arrayTwo = TransferElements(arrayOne);
    PrintArray(arrayTwo);
}

void FillArrayRandomly(string[] arr)
{
    Random rand = new Random();
    string AlmostAllSymbols = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$%^&*";
    {
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(1,7);
        for (int j = 0; j < size; i++)
        {
            arr[i] += AlmostSymbol[rand.Next(0,AlmostAllSymbol.Length)];
        }
    }
    }
}

void FillArray (string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] - Console.ReadLine() ?? "";
    }
}

void PrintArray(string[] arr, object Console)
{
    Console.Write("[ ");    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "");
    }
    Console.Write("]");
}

int GetSazeOfSecondArrey(string[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}

string[] TransferElements(string[] arr)
{
    string[] arrayTwo new string[GetSazeOfSecondArrey(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}
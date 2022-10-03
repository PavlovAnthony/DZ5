string ReadData(string line)
{

    Console.Write(line);
    string a = Console.ReadLine();
    CheckNumber(a);
    return a;
}

int  CheckNumber(string x)
{
    int num = 0;

    bool isNum = int.TryParse(x, out num);
    if (isNum == false|| num<0)
    {
        PrintData("Ошибка ввода: ", "значение Null либо введены не числа");
        Environment.Exit(0);
    }
return num;
}
int [] InitArray(int demension)
{
    int[] arr = new int[demension];

    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(100,999);
    }

    return arr;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

//метод, который печатает массив на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод, который считает количество четных чисел в массиве
int GetCountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
            count++; 
    }
    return count;
}
int masslength = Convert.ToInt32(ReadData("Введите количество элементов в массиве : "));

int [] arr = InitArray(masslength);;
PrintArray(arr);

int counteven = GetCountEvenElements(arr);

Console.WriteLine($"Количество четных элементов = {counteven} " );



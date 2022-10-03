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
    if (isNum == false|| num<=0)
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
        arr[i] = rnd.Next(-100,100);
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
int GetSumEvenElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 == 1)
            sum += array[i] ; 
    }
    return sum;
}
int masslength = Convert.ToInt32(ReadData("Введите количество элементов в массиве : "));

int [] arr = InitArray(masslength);;
PrintArray(arr);

int counteven = GetSumEvenElements(arr);

Console.WriteLine($"Сумма элементов на нечетных позициях= {counteven} " );



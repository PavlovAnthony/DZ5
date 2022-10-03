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
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}


double [] InitArray(int demension)
{
    double[] arr = new double[demension];

    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(-50,50);
    }

    return arr;
}
//метод, который печатает массив на консоль
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод, который считает количество четных чисел в массиве
double GetMinMax(double[] array)
{
    double temp = 0;
    double max = array[0];
    double min = array[0];
        for (int i = 1; i < array.Length; i++)
    {
        if( array[i]>max)
            max = array[i] ; 
    }
    for (int i = 1; i < array.Length; i++)
    {
        if( array[i]<min)
            min = array[i] ; 
    }
    
    return Math.Round(max- min ,3);
}
int masslength = Convert.ToInt32(ReadData("Введите количество элементов в массиве : "));

double [] arr = InitArray(masslength);;
PrintArray(arr);

double counteven = GetMinMax(arr);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива= {counteven} " );



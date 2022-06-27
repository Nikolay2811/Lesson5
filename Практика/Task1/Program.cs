// адача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
void Array(int[] dlina)
{
    int length = dlina.Length;
    int index = 0;
    while (index < length)
    {
        dlina[index] = new Random().Next(-9, 10);
        index++;
    }
}

int[] mass = new int[12];
Array(mass);
int a = 0;
int b = 0;
int count = 0;
while (count < mass.Length)
{
    if (mass[count] > 0)
    {
        a = a +mass[count];
        count++;
    }
    else
    {
        b = b +mass[count];
        count++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}
PrintArray(mass);
Console.WriteLine( "сумма положительных чисел в массиве равна " + a + " сумма отрицательных чисел в массиве равна "+b );
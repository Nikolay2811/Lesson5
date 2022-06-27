// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateArray(int large)
{
    double[] array =new double[large];
    for ( int count = 0; count < array.Length; count++ )
    {
        array[count] = new Random().Next(0, 100) + new Random().NextDouble();
    }
    return array;
}
int promt (string messege)
{
    Console.Write(messege);
    string number = Console.ReadLine();
    int numberInt=int.Parse(number);
    return numberInt;
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position ++;
    }
}
int a =promt ("Ведите длинну массива => " );
double[] mass = CreateArray(a);
double min = mass[0];
double max = mass[0];
for (int index =0; index < mass.Length; index++)
{
if (min > mass[index])
 min = mass[index];
if (max < mass[index])
max = mass[index];
}
double sum = max - min;
PrintArray(mass);
Console.WriteLine( $"разность между max " + max +" и min" + min + " значения массива равна "+ sum);
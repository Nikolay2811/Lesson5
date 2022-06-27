// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateArray(int lenght)
{
    int[] array = new int[lenght];
    for (int count=0; count < array.Length; count++)
    {
        array[count]= new Random().Next(100, 1000);
    }
   return array;
}
int[] mass = CreateArray(5);
int sum =0;

for (int index=0;  index < mass.Length; index++)
{
    if (mass[index]%2 == 0)
    {sum++;}
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position ++;
    }
}

PrintArray(mass);
Console.WriteLine("Кол-во четных чисел в масиве "+sum);
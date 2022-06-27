// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int [] CreateArray(int large)
{
    int[] array =new int[large];
    for ( int count = 0; count < array.Length; count++ )
    {
        array[count] = new Random().Next(0, 101);
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

int a = promt("Ведите размер массива => ");
int[] mass = CreateArray(a);
int sum = 0;
for (int count = 0; count < mass.Length; count = count+2)
{
    sum = sum + mass[count];
}
PrintArray(mass);
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях = " +sum);
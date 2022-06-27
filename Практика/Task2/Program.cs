// Задача 1: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
void GreateMass(int[] a)
{
    int lenght = a.Length;
    int index = 0;
    while (index < lenght)
{
    a[index] = new Random().Next(-10, 11);
    index++;
}

}

int[] mass = new int[5];
int a = 0;
GreateMass(mass);
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
int b = mass.Length;
while (a < b)
{
    mass[a] = mass[a] * -1;
    a++;
}

PrintArray(mass);
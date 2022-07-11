/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */

void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double[] mass = new double[3];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next() + new Random().NextDouble();
}
Print(mass);
double min = mass [0];
double max = mass [0];

for (int i = 0; i < mass.Length; i++)
{
    if(mass [i]< min) min = mass [i];
    if(mass [i]> max) max = mass [i];
}
double diff = max - min;

 Console.WriteLine("мин элемент: " +min);
 Console.WriteLine("макс элемент: " +max);
 Console.WriteLine("разница между макс и мин элементами: " + diff);
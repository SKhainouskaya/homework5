/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях. [3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void print (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write (arr[i]+ " ");
    }
    Console.WriteLine ();
}

int[]mass = new int [10];
for (int i = 0; i <mass.Length ; i++)
{
    mass[i]= new Random().Next(-10, 10);
}
print(mass);

int sum =0;
for (int i = 1; i<=mass.Length; i+=2)
{
    sum+= mass[i];
}
Console.WriteLine(sum);
//Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
//Определить сумму максимального и минимального элементов массива.

int[] array = new int[15];
Random random = new Random();

array[0] = random.Next(0, 51);
int min = array[0];
int max = array[0];
Console.WriteLine(array[0]);


for (int i = 1; i < 15; i++)
{
    array[i] = random.Next(0, 51);
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
    Console.WriteLine(array[i]);
}

Console.WriteLine("max = {0}, min = {1}, max+min = {2}", max, min, max + min);
Console.ReadKey();

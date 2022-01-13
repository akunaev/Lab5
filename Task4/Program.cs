//Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
//Определить количество   нечетных положительных элементов, стоящих на четных местах.


int[] array = new int[20];
Random random = new Random();

int n = 0;

for (int i = 0; i < 20; i++)
{
    array[i] = random.Next(-50, 51);
    Console.Write("{0} ", array[i]);
    if (i % 2 == 0 && array[i] % 2 != 0 && array[i] > 0)
    {
        n++;
    }
}
Console.WriteLine("");
Console.WriteLine("Количество нечетных положительных элементов на четных местах - {0}",n);
Console.ReadKey();

//Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.

double[] array = new double[7];
double Sum = 0;
for (int i = 0; i < 7; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
    Sum += array[i];
}
Console.WriteLine("Среднее арифметическое равно {0,5:f2}", Sum / 7);
Console.ReadKey();

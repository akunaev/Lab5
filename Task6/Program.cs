//Запросить у пользователя целочисленное значение N.
//Сформировать двумерный массив размера NxN. Заполнить массив числами, вводимыми с клавиатуры.
//Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
//Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.

Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n];

Console.WriteLine("Введите элементы массива слева направо, сверху вниз");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("");
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine("");
}

int[] columns = new int[n];
int[] rows = new int[n];
int d1 = 0, d2 = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        columns[i] += array[j, i];
        rows[i] += array[i, j];
    }
    d1 += array[i, i];
    d2 += array[n - 1 - i, i];
}

bool flag = true;

if (d1 != d2) { flag = false; }
else
{
    for (int i = 0; i < n; i++)
    {
        if (columns[i] != d1 || rows[i] != d2) { flag = false; }
    }
}

if (flag) { Console.WriteLine("Это магический квадрат"); }
else { Console.WriteLine("Это не магический квадрат"); }
Console.ReadKey();

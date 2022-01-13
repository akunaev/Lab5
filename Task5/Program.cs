//Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
//1 0 1 0 1
//0 1 0 1 0
//1 0 1 0 1
//0 1 0 1 0
//1 0 1 0 1

Console.WriteLine("Введите размерность массива");
int n =Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n,n];

for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = (i + j + 1) % 2;
        Console.Write("{0} ",array[i,j]);
    }
    Console.WriteLine("");
}
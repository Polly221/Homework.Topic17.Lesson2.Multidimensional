int[][] mas = new int[3][];
mas[0] = new int[5] { 1, 3, 6, 5, 4 };
mas[1] = new int[3] { 3, 4, 7 };
mas[2] = new int[4] { 2, 5, 6, 8 };
for (int i = 0; i < mas.Length; i++)
{
    for (int j = 0; j < mas[i].Length; j++)
    {
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}
int sum1 = 0;
int sum2 = 0;
int sum3 = 0;

foreach (int i in mas[0])
{
    sum1 += i;
}
foreach (int i in mas[1])
{
    sum2 += i;
}
foreach (int i in mas[2])
{
    sum3 += i;
}
Console.Write("Сумма элементов первого одномерного массива: " + sum1 +
    "\nСумма элементов второго одномерного массива: " + sum2 + 
    "\nСумма элементов третьего одномерного массива: " + sum3);
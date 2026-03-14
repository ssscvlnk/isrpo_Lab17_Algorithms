Console.WriteLine("Вывод максимального элемента массива");
int[] array = { 5, 4, 5, 3, 4 };
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Максимальный элемент: {max}");
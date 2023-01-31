// Console.WriteLine("Введите размер массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[n];
// InputArrayRandomNumbers(numbers);
// Console.WriteLine("цифры в массиве: ");
// PrintArray(numbers);
// int count = 0;

// for (int m = 0; m < numbers.Length; m++)
// if (numbers[m] % 2 == 0) count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void InputArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000); // [100, 999]
}


int CountEvenInArray(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
      if (element % 2 == 0)
        count++; // count = count + 1;
    }
    return count;
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {CountEvenInArray(array)}");
